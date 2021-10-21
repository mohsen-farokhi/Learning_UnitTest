using OpenQA.Selenium;

namespace UOM.Technical.WebUI.Framework.Interaction
{
    public class Click : WebInteraction
    {
        private readonly By _by;

        public Click(By by)
        {
            _by = by;
        }

        public override void Execute(IWebDriver webDriver)
        {
            webDriver.FindElement(_by).Click();
        }
    }
}
