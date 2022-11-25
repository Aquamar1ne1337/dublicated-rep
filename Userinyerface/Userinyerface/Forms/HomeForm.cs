using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinyerface.Forms
{
    public class HomeForm : Form
    {
        public HomeForm() : base(By.XPath("//button[@class='start__button']"), "UniqueElementOfMainPage") { }

        private IButton _nextPageButton => ElementFactory.GetButton(By.XPath("//a[@class='start__link']"), "NextPageButton");

        public void ClickNextPageButton()
        {
            _nextPageButton.Click();
        }
    }
}