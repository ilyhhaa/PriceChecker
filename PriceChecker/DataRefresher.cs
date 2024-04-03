using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChecker
{
    internal class DataRefresher
    {
        public static Form1 form1;
        public static List<TrackerItem> trackers;
        public static bool keepRunning;
        internal static int frequency;
        internal static Thread threadHandle;

        public static void RefreshData()
        {
            DateTime now = DateTime.Now;
            DateTime lastRun = DateTime.Now.AddMilliseconds(-2 * frequency);
            var opt = new ChromeOptions();
            opt.AddArgument(@"user-data-dir=C:/Users/Administrator/AppData/Local/Google/Chrome/User Data");
            opt.AddArgument("headless");

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.SuppressInitialDiagnosticInformation= true;
            service.HideCommandPromptWindow = true;
            var driver = new ChromeDriver(service,opt);
            while (keepRunning)
            {
                now=DateTime.Now;
                if (lastRun.AddMilliseconds(frequency) < now)
                {
                    foreach (TrackerItem item in trackers)
                    {
                        try
                        {
                            driver.Url = item.URL.Trim();
                            System.Threading.Thread.Sleep(1000);
                                var v = driver.FindElement(By.XPath(item.URL.Trim()));
                            var str = v.Text;
                            if (str != null && str.Length > 0)
                            {
                                if (item.CurrVal!=str)
                                {
                                    item.PrevVal = item.CurrVal;
                                    item.CurrVal = str;
                                    item.LastChanged = DateTime.Now.ToString("MM-dd:HH:mm:ss");

                                }
                                item.LastChecked = DateTime.Now.ToString("MM-dd:HH:mm:ss");
                            }  
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                    lastRun = DateTime.Now;
                }
                form1.Update();
                Thread.Sleep(5000);
            }
            driver.Quit();
          
        }
    }
}
