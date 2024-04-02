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
                System.Threading.Thread.Sleep(2000);

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
    }
}