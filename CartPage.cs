using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class CartPage
    {
        private IWebDriver Driver;
        public CartPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        //Driver.FindElement(By.Id("user-name"));
        [FindsBy(How = How.Id, Using = "continue-shopping")]
        public IWebElement continueshoppingbtn;

        [FindsBy(How = How.Id, Using = "checkout")]
        public IWebElement checkoutbtn;

        [FindsBy(How = How.Id, Using = "remove-sauce-labs-backpack")]
        public IWebElement A2c_Sauce_Labs_Backpack;

        [FindsBy(How = How.Id, Using = "remove-sauce-labs-bike-light")]
        public IWebElement Sauce_Labs_Bike_Light;

        [FindsBy(How = How.Id, Using = "remove-sauce-labs-bolt-t-shirt")]
        public IWebElement Sauce_Labs_Bolt_t_shirt;


        [FindsBy(How = How.Id, Using = "remove-sauce-labs-fleece-jacket")]
        public IWebElement Sauce_Labs_fleece_jacket;


        [FindsBy(How = How.Id, Using = "remove-sauce-labs-onesie")]
        public IWebElement Sauce_Labs_onesie;

        [FindsBy(How = How.Id, Using = "rwemove-test.allthethings()-t-shirt-(red)")]
        public IWebElement Sauce_Labs_redTshirt;

        public void clickcontinue()
        {
            continueshoppingbtn.Click();
        }
        public void clickcheckout()
        {
            checkoutbtn.Click();
        }

        public void RemoveBackpack()
        {
            A2c_Sauce_Labs_Backpack.Click();
        }
        public void RemoveBikelight()
        {
            Sauce_Labs_Bike_Light.Click();
        }
        public void RemoveRedtshirt()
        {
            Sauce_Labs_redTshirt.Click();
        }
        public void RemoveBolttshirt()
        {
            Sauce_Labs_Bolt_t_shirt.Click();
        }
        public void RemoveFleeceJacket()
        {
            Sauce_Labs_fleece_jacket.Click();
        }
        public void RemoveOnesie()
        {
            Sauce_Labs_onesie.Click();
        }

    }
}
