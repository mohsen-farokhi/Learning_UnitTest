using OpenQA.Selenium;

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
        }
    }
}
