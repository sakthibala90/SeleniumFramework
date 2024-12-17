using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver;
        public LoginPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        //Driver.FindElement(By.Id("user-name"));
        [FindsBy(How=How.Id,Using ="user-name")]
        private IWebElement UserName { get; set; }

        public IWebElement GetUsername()
        {
            return UserName;
        }

        [FindsBy(How = How.Id, Using = "password")]
        public  IWebElement Password;

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement LoginButton;
        public void ValidLogin(string user,string pass)
        {
            GetUsername().SendKeys(user);
            Password.SendKeys(pass);
            LoginButton.Click();
        }


    }
}
