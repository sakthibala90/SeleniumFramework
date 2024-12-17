using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class InformationPage
    {
        private IWebDriver Driver;
        public InformationPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        //Driver.FindElement(By.Id("user-name"));
        [FindsBy(How = How.Id, Using = "first-name")]
        public IWebElement firstname;

        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement lastname;

        [FindsBy(How = How.Id, Using = "postal-code")]
        public IWebElement postalcode;

        [FindsBy(How = How.Id, Using = "cancel")]
        public IWebElement cancelbtn;

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement continuebtn;

        public void Info(string fname,string lname,string zipcode)
        {
            firstname.SendKeys(fname);
            lastname.SendKeys(lname);
            postalcode.SendKeys(zipcode);
        }

        public void cancelclick()
        {
            cancelbtn.Click();

        }

        public void clickcontinue()
        {
            continuebtn.Click();

        }
    }
}
