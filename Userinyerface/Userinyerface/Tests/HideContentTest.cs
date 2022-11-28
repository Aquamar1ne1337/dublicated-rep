using NUnit.Framework;
using Userinyerface.Forms;

namespace Userinyerface.Tests
{
    public class HideContentTest : BaseTest
    {
        [Test]
        public void HideContentTesting()
        {
            var homeForm = new HomeForm();
            Assert.IsTrue(homeForm.State.WaitForDisplayed(), "Home Page is not opened.");
            homeForm.ClickNextPageButton();

            var loginForm = new LoginForm();

            loginForm.ClickHideButton();
            Assert.IsTrue(loginForm.WaitForHelpContainerHidden(), "Help menu is not hidden.");
        }
    }
}