using NUnit.Framework;
using Userinyerface.Forms;


namespace Userinyerface.Tests
{
    public class CardTest : BaseTest
    {
        [Test]
        public void CardsTest()
        {
            var homeForm = new HomeForm();
            Assert.IsTrue(homeForm.State.WaitForDisplayed(), "Home Page is not opened.");

            homeForm.ClickNextPageButton();

            var loginForm = new LoginForm();
            Assert.IsTrue(loginForm.State.WaitForDisplayed(), "Login Page is not opened.");

            loginForm.InputPassword();
            loginForm.InputEmail();
            loginForm.InputDomain();
            loginForm.SelectRandomValueInComboBox();
            loginForm.AcceptTerms();
            loginForm.ClickNextButton();

            var avatarForm = new AvatarForm();
            Assert.IsTrue(avatarForm.State.WaitForDisplayed(), "Avatar Page is not opened.");
            avatarForm.ClickUploadButton();
        }
    }
}