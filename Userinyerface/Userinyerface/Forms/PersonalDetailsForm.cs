using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinyerface.Forms
{
    public class PersonalDetailsForm : Form
    {
        public PersonalDetailsForm() : base(By.XPath("//div[@class='personal-details__form']"), "UniqueElementOfPersonalDetailsPage") { }  
    }
}