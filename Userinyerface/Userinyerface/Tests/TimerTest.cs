using NUnit.Framework;
using Userinyerface.Forms;

namespace Userinyerface.Tests
{
    public class TimerTest : BaseTest
    {
        [Test]
        public void ValidateTimer()
        {
            HomeForm homeForm = new HomeForm();
            Assert.IsTrue(homeForm.State.WaitForDisplayed(), "Home Page is not opened.");
            homeForm.ClickNextPageButton();

            LoginForm loginForm = new LoginForm();
            string timerValue = loginForm.GetTimerStartTime();
            Assert.That(timerValue, Does.EndWith("00:00"));
        }
    }
}