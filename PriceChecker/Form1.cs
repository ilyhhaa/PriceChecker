using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PriceChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}