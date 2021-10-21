using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace UISample
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory))
            //{
            //    driver.Navigate().GoToUrl("https://google.com");
            //    driver.FindElement(By.Name("q")).SendKeys("mohsen farokhi");
            //    driver.FindElement(By.Name("btnK")).Click();
            //}

            using (IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory))
            {
                driver.Navigate().GoToUrl("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=45507655586782998");

                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                js.ExecuteScript("ii.ShowTab(7)");

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                var element = driver.FindElement(By.ClassName("ArrowUp"));

                var parent = element.FindElement(By.XPath("./../.."));

                //var text2 = parent.GetAttribute("innerHTML");
                var text = parent.Text;

                driver.Close();
            }
        }
    }
}
