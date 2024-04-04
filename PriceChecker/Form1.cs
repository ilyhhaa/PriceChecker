using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace PriceChecker
{
    public partial class Form1 : Form
    {
        List<TrackerItem>? items;
        public Form1()
        {
            InitializeComponent();
            items = new List<TrackerItem>();

            if (File.Exists("data.json"))
            {
                var data = File.ReadAllText("data.json");
                items = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TrackerItem>>(data);
            }
            else
            {
                items = new List<TrackerItem>();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void refreshRec()
        {
            File.Delete("data.json");
            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(items, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("data.json", newJsonResult);
        }

        private void syncList()
        {
            listTrackers.Items.Clear();

            foreach (TrackerItem item in items)
            {
                listTrackers.Items.Add(new ListViewItem(new String[] { item.Name, item.PrevVal, item.CurrVal, item.LastChecked, item.LastChanged }));
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var opt = new ChromeOptions();

                opt.AddArgument(@"user-data-dir=C:/Users/Administrator/AppData/Local/Google/Chrome/User Data");
                opt.AddArgument("headless");


                ChromeDriverService service = ChromeDriverService.CreateDefaultService();

                service.SuppressInitialDiagnosticInformation = true;
                service.HideCommandPromptWindow = true;
                var driver = new ChromeDriver(service, opt);

                driver.Manage().Window.Minimize();
                driver.Url = txtUrl.Text;
                //https://mobi-lux.by/kompyutery-i-periferiya/videokarty/sapphire/videokarta-sapphire-radeon-rx-6700-xt-12gb-gddr6-11306-02-20g
                System.Threading.Thread.Sleep(3000);

                var v = driver.FindElement(By.XPath(textSelector.Text));
                ////p[@class='sku__price ']
                var str = v.Text;
                driver.Quit();

                lblTest.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            items.Add(new TrackerItem
            {
                Name = txtName.Text,
                URL = txtUrl.Text,
                Selector = textSelector.Text,
                CurrVal = "N/A",
                PrevVal = "N/A",
                LastChanged = "N/A",
                LastChecked = "N/A"
            });
            syncList();
            refreshRec();

        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            var sels = listTrackers.SelectedIndices;

            foreach (var sel in sels)
            {
                items.RemoveAt((int)sel);

                syncList();
                refreshRec();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 0:
                    DataRefresher.frequency = 600000;
                    lblFrequency.Text = "10 Min";
                    break;
                case 1:
                    DataRefresher.frequency = 1800000;
                    lblFrequency.Text = "30 Min";
                    break;
                case 2:
                    DataRefresher.frequency = 3600000;
                    lblFrequency.Text = "1 Hour";
                    break;
                case 3:
                    DataRefresher.frequency = 5400000;
                    lblFrequency.Text = "1.5 Hour";
                    break;
                case 4:
                    DataRefresher.frequency = 43200000;
                    lblFrequency.Text = "12 Hours";
                    break;
                case 5:
                    DataRefresher.frequency = 86400000;
                    lblFrequency.Text = "24 Hours";
                    break;
                default:
                    break;
            }
        }

        public void UpdateRec()
        {
            try
            {
                listTrackers.BeginInvoke((MethodInvoker)delegate ()
                {
                    syncList();
                    refreshRec();
                });
            }
            catch (Exception ex)
            {

                
            }
        }

        private void StartTrackingButton_Click(object sender, EventArgs e)
        {
            if (StartTrackingButton.Text == "Start Tracking")
            {
                DataRefresher.form1 = this;
                DataRefresher.trackers = items;
                DataRefresher.keepRunning = true;
                ThreadStart start = new ThreadStart(DataRefresher.RefreshData);
                Thread thread = new Thread(start);
                thread.Start();
                StartTrackingButton.Text = "Stop Tracking";
            }
            else
            {
                DataRefresher.keepRunning = false;
                StartTrackingButton.Text = "Start Tracking";
            }
        }
    }
}


/*The error says selenium can't find the item, this could be due to:
Incorrect xpath(exclude)
Delay in loading the item(probably)
Dynamic page change(Unlikely)*/




/*
I put a big delay and a new error came up 
Failed to execute 'evaluate' on 'Document':The string 
Can't find an element on the page? 
Let's try to rewrite for Css Selector
 */