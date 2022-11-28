using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinyerface.Forms
{
    public class PersonalDetailsForm : Form
    {
        public PersonalDetailsForm() : base(By.XPath("//div[@class='personal-details__form']"), "PersonalDetailsBox") { }

        private ILabel _cardNumberLabel => ElementFactory.GetLabel(By.ClassName("page-indicator"), "CardNumberLabel");

        public string GetCardNumber()
        {
            return _cardNumberLabel.Text;
        }
    }
}