using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinyerface.Forms
{
    public class HomeForm : Form
    {
        public HomeForm() : base(By.ClassName("start__button"), "StartButton") { }

        private IButton _nextPageButton => ElementFactory.GetButton(By.ClassName("start__link"), "NextPageButton");

        public void ClickNextPageButton()
        {
            _nextPageButton.Click();
        }
    }
}