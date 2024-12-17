using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class Overviewpage
    {
        private IWebDriver Driver;
        public Overviewpage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }
        //Driver.FindElement(By.Id("user-name"));
        [FindsBy(How = How.Id, Using = "cancel")]
        public IWebElement cancelbtn;

        [FindsBy(How = How.Id, Using = "finish")]
        public IWebElement Finishbtn;
        public void clickcancel()
        {
            cancelbtn.Click();

        }

        public void clickfinish()
        {
            Finishbtn.Click();

        }
    }
}
