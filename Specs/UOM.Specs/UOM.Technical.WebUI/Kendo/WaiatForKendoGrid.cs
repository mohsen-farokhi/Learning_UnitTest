using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using UOM.Technical.WebUI.Framework.Interaction;

namespace UOM.Technical.WebUI.Kendo
{
    public class WaiatForKendoGrid : WebInteraction
    {
        public override void Execute(IWebDriver webDriver)
        {
            var wait = new WebDriverWait(webDriver, timeout: TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("k-loading-image")));
        }
    }
}
