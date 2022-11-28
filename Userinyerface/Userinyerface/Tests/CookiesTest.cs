using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Userinyerface.Forms;

namespace Userinyerface.Tests
{
    public class CookiesTest : BaseTest
    {
        [Test]
        public void AcceptCookiesTest()
        {
            var homeForm = new HomeForm();
            Assert.IsTrue(homeForm.State.WaitForDisplayed(), "Home Page is not opened.");

            homeForm.ClickNextPageButton();

            var loginForm = new LoginForm();
            loginForm.ClickAcceptCookies();

            Assert.IsTrue(loginForm.IsFormWithCookiesClosed(), "Cookies form is still present.");
        }
    }
}