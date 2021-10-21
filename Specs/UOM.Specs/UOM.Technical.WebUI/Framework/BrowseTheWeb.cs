using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Suzianna.Core.Screenplay;
using System;

namespace UOM.Technical.WebUI.Framework
{
    public class BrowseTheWeb : IAbility , IDisposable
    {
        public BrowseTheWeb()
        {
            Driver = new ChromeDriver();
        }

        public IWebDriver Driver { get; private set; }

        public void Dispose()
        {
            Driver.Close();
            Driver?.Dispose();
        }
    }
}
