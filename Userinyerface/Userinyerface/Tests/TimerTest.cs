using NUnit.Framework;
using Userinyerface.Forms;
using Userinyerface.Models;
using Userinyerface.Utilities;

namespace Userinyerface.Tests
{
    public class TimerTest : BaseTest
    {
        [Test]
        public void ValidateTimer()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.ClickNextPageButton();

            LoginForm loginForm = new LoginForm();
            string timerValue = loginForm.GetTimerTime();
            Assert.That(timerValue, Does.StartWith(DataReader.testData.Time));
        }
    }
}