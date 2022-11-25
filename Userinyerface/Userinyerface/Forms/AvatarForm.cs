using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using WindowsInput.Native;
using WindowsInput;
using System.IO;
using Userinyerface.Utilities;
using Aquality.Selenium.Browsers;
using System.Threading;
using System;
using Aquality.Selenium.Elements.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Userinyerface.Forms
{
    public class AvatarForm : Form
    {
        public AvatarForm() : base(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "UniqueElementOfAvatarPage") { }

        private IList<ICheckBox> _interestCheckBox = ElementFactory.FindElements<ICheckBox>(By.XPath("//span[@class='checkbox__box']"), "InterestsCheckBoxes");

        public void ClickUploadButton()
        {
            FormElement.Click();
            InputSimulator a = new InputSimulator();
            FileInfo f = new FileInfo(Constans.ImageToUploadPath);
            a.Keyboard.TextEntry(f.FullName);
            Thread.Sleep(1000);
            a.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

        public void ClickInterestChechBoxes(int numberOfCheckBoxes)
        {
            int temp = -1;
            int randomNumber = -1;
            for (int i = 1; i <= numberOfCheckBoxes; i++)
            {
                while (temp == randomNumber)
                {
                    randomNumber = RandomUtils.GetRundomNumber(_interestCheckBox.Count);
                }
                temp = randomNumber;
                _interestCheckBox[randomNumber].Click();
            }
        }
    }
}