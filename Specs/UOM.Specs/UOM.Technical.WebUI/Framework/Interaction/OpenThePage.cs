using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace UOM.Technical.WebUI.Framework.Interaction
{
    public class OpenThePage : WebInteraction
    {
        private readonly string _url;

        public OpenThePage(string url)
        {
            _url = url;
        }

        public override void Execute(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(_url);

            var wait = new WebDriverWait(webDriver, timeout: TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("allDimensionBtn")));

        }
    }
}
