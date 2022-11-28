using Aquality.Selenium.Browsers;
using NUnit.Framework;
using Userinyerface.Utilities;

namespace Userinyerface.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            var browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo(DataReader.configData.Url);
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