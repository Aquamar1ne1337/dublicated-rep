using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using AutoIt;
using System.IO;
using Aquality.Selenium.Browsers;

namespace Userinyerface.Forms
{
    public class AvatarForm : Form
    {
        public AvatarForm() : base(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "UniqueElementOfAvatarPage") { }


        public void ClickUploadButton()
        {
            //FormElement.SendKeys(@"Resources/Images/test.jpg");
            
            FormElement.Click();
            AutoItX.WinActivate("File Upload");
            string imagePath = "Resources/Images/test.jpg";
            FileInfo f = new FileInfo(imagePath);
            string fullPath = f.FullName;
            AutoItX.Send(fullPath);       
            AutoItX.Send("{ENTER}");
        }
    }
}