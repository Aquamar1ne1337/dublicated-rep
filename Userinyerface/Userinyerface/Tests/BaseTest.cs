using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using NUnit.Framework;
using Userinyerface.Models;
using Userinyerface.Utilities;

namespace Userinyerface.Tests
{
    public class BaseTest
    {
        protected ConfigDataModel configData;

        [OneTimeSetUp]
        [Order(0)]
        public void ReadConfigData()
        {
            configData = new JsonSettingsFile(Constans.ConfigDataPath).GetValue<ConfigDataModel>("config");
        }

        [SetUp]
        public void SetUp()
        {
            var browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo(configData.Url);
            browser.WaitForPageToLoad();
        }

        [TearDown]
        public void TearDown()
        {
            var browser = AqualityServices.Browser;
            if (browser.IsStarted)
                browser.Quit();
        }
    }
}