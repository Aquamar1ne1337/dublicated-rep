using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using Userinyerface.Utilities;

namespace Userinyerface.Forms
{
    public class LoginForm : Form
    {
        private string _email = RandomUtils.GetRandomLatinString();

        public LoginForm() : base(By.XPath("//a[@class='login-form__terms-conditions']"), "UniqueElementOfLoginPage") { }

        private ITextBox _passwordTextBox => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Choose Password']"), "PasswordTextBox");
        private ITextBox _emailTextBox => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Your email']"), "EmailTextBox");
        private ITextBox _domainTextBox => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Domain']"), "DomainTextBox");
        private IComboBox _domainDropBox => ElementFactory.GetComboBox(By.XPath("//div[@class='dropdown__header']"), "DomainComboBox");
        private IList<ILabel> _domainDropBoxRow => ElementFactory.FindElements<ILabel>(By.XPath("//div[@class='dropdown__list-item']"), "DomainDropBoxRow");
        private ICheckBox _termsCheckBox => ElementFactory.GetCheckBox(By.XPath("//span[@class='checkbox__box']"), "TermsCheckBox");
        private IButton _nextButton => ElementFactory.GetButton(By.XPath("//a[@class='button--secondary']"), "NextButton");
        private IButton _hideButton => ElementFactory.GetButton(By.XPath("//button[contains(@class,'help-form__send-to-bottom-button')]"), "HideButton");
        private IButton _cookiesButton => ElementFactory.GetButton(By.XPath("//button[contains(@class,'button button--solid button--transparent')]"), "AcceptCookiesButton");
        private ITextBox _cookiesContainer => ElementFactory.GetTextBox(By.XPath("//div[@class='cookies']"), "CookiesContainer");
        private ITextBox _hideContainer => ElementFactory.GetTextBox(By.XPath("//*[contains(@class,'help-form__title')]"), "HideContainer");
        private ILabel _timerLabel => ElementFactory.GetLabel(By.XPath("//div[contains(@class,'timer timer--white')]"), "Timer");

        public void ClickAcceptCookies()
        {
            _cookiesButton.WaitAndClick();
        }

        public bool IsFormWithCookiesClosed()
        {
            return _cookiesContainer.State.IsDisplayed;
        }

        public string GetTimerStartTime()
        {
            return _timerLabel.Text;
        }

        public bool IsHelpContainerHidden()
        {
            return _hideContainer.State.WaitForNotDisplayed();
        }

        public void ClickHideButton()
        {
            _hideButton.Click();
        }

        public void InputPassword()
        {
            var password = RandomUtils.GetRandomPassword() + _email[0];
            _passwordTextBox.ClearAndType(password);
        }

        public void InputEmail()
        {
            _emailTextBox.ClearAndType(_email);
        }

        public void InputDomain()
        {
            _domainTextBox.ClearAndType(RandomUtils.GetRandomLatinString());
        }

        public void SelectRandomValueInComboBox()
        {
            _domainDropBox.Click();
            var indexOfRandomDomain = RandomUtils.GetRundomNumber(_domainDropBoxRow.Count);
            _domainDropBoxRow[0].Click();
        }

        public void AcceptTerms()
        {
            _termsCheckBox.Check();
        }

        public void ClickNextButton()
        {
            _nextButton.Click();
        }
    }
}