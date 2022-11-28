using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using WindowsInput.Native;
using WindowsInput;
using System.IO;
using Userinyerface.Utilities;
using System.Threading;
using Aquality.Selenium.Elements.Interfaces;
using System.Collections.Generic;

namespace Userinyerface.Forms
{
    public class AvatarForm : Form
    {
        public AvatarForm() : base(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "UniqueElementOfAvatarPage") { }

        private IList<ICheckBox> _interestCheckBox = ElementFactory.FindElements<ICheckBox>(By.XPath("//span[@class='checkbox__box']"), "InterestsCheckBoxes");
        private IButton _nextButton = ElementFactory.GetButton(By.XPath("//button[text()='Next']"), "NextButton");

        public void ClickNextButton()
        {
            _nextButton.Click();
        }

        public void ClickUploadButton()
        {
            FormElement.Click();
            InputSimulator a = new InputSimulator();
            FileInfo f = new FileInfo(Constans.ImageToUploadPath);
            a.Keyboard.TextEntry(f.FullName);
            Thread.Sleep(1500);
            a.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

        public void ClickInterestChechBoxes(int numberOfCheckBoxes)
        {    
            _interestCheckBox[_interestCheckBox.Count - 1].Click();
            int temp = -1;
            int randomNumber = -1;
            for (int i = 1; i <= numberOfCheckBoxes; i++)
            {
                while (temp == randomNumber || randomNumber == 17)
                {
                    randomNumber = RandomUtils.GetRundomNumber(_interestCheckBox.Count - 2);
                }
                temp = randomNumber;
                _interestCheckBox[randomNumber].Click();
            }
        }
    }
}