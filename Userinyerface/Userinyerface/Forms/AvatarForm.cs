using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using WindowsInput.Native;
using Userinyerface.Utilities;
using System.Threading;
using Aquality.Selenium.Elements.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Userinyerface.Forms
{
    public class AvatarForm : Form
    {
        private const int NumberToSubscratcFromCheckBoxes = 2;

        public AvatarForm() : base(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "UploadImageButton") { }

        private IList<ICheckBox> _interestCheckBox => ElementFactory.FindElements<ICheckBox>(By.ClassName("checkbox__box"), "InterestsCheckBoxes");
        private IButton _nextButton => ElementFactory.GetButton(By.XPath("//button[text()='Next']"), "NextButton");
        private ILabel _cardNumberLabel => ElementFactory.GetLabel(By.ClassName("page-indicator"), "CardNumberLabel");

        public string GetCardNumber()
        {
            return _cardNumberLabel.Text;
        }

        public void ClickNextButton()
        {
            _nextButton.Click();
        }

        public void ClickUploadButton()
        {
            FormElement.Click();
            SimulationUtil.UploadImage(Paths.ImageToUploadPath);
        }

        public void ClickInterestChechBoxes(int numberOfCheckBoxes)
        {
            ClickUnselectAll();
            var availableCheckBoxNumber = _interestCheckBox.Count - NumberToSubscratcFromCheckBoxes;
            var availableCheckBoxes = Enumerable.Range(1, availableCheckBoxNumber).ToList();
            availableCheckBoxes.Remove(DataReader.testData.SelectAllCheckBoxNumber);
            for (int i = 1; i <= numberOfCheckBoxes; i++)
            {
                var index = RandomUtils.GetRundomNumber(0, availableCheckBoxes.Count);
                var randomNumber = availableCheckBoxes[index];
                availableCheckBoxes.RemoveAt(index);
                _interestCheckBox[randomNumber].Click();
            }
        }

        private void ClickUnselectAll()
        {
            _interestCheckBox[_interestCheckBox.Count - 1].Click();
        }
    }
}