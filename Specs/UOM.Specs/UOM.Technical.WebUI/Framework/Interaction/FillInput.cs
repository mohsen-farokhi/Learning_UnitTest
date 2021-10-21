using OpenQA.Selenium;

namespace UOM.Technical.WebUI.Framework.Interaction
{
    public class FillInput : WebInteraction
    {
        private readonly By _by;
        private readonly string _text;

        public FillInput(By by, string text)
        {
            _by = by;
            _text = text;
        }

        public override void Execute(IWebDriver webDriver)
        {
            webDriver.FindElement(_by).SendKeys(_text);
        }
    }
}
