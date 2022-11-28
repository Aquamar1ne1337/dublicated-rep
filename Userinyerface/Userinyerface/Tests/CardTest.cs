using NUnit.Framework;
using Userinyerface.Forms;
using Userinyerface.Utilities;

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
            Assert.That(loginForm.GetCardNumber(), Does.StartWith(DataReader.testData.FirstCard), "The '1' card is not opened.");

            loginForm.InputRandomPasswordWithFirstLetterOfEmail();
            loginForm.InputEmail();
            loginForm.InputDomain();
            loginForm.SelectRandomDomainInComboBox();
            loginForm.AcceptTerms();
            loginForm.ClickNextButton();

            var avatarForm = new AvatarForm();
            Assert.That(avatarForm.GetCardNumber(), Does.StartWith(DataReader.testData.SecondCard), "The '2' card is not opened.");

            avatarForm.ClickInterestChechBoxes(DataReader.testData.NumberOfCheckBoxes);
            avatarForm.ClickUploadButton();
            avatarForm.ClickNextButton();

            var personalDetailsForm = new PersonalDetailsForm();
            Assert.That(personalDetailsForm.GetCardNumber(), Does.StartWith(DataReader.testData.ThirdCard), "The '3' card is not opened.");
        }
    }
}