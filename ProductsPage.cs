using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class ProductsPage
    {
        private IWebDriver Driver;
        public ProductsPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        //Driver.FindElement(By.Id("user-name"));
        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")]
        public IWebElement A2c_Sauce_Labs_Backpack;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bike-light")]
        public IWebElement Sauce_Labs_Bike_Light;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bolt-t-shirt")]
        public IWebElement Sauce_Labs_Bolt_t_shirt;


        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-fleece-jacket")]
        public IWebElement Sauce_Labs_fleece_jacket;


        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-onesie")]
        public IWebElement Sauce_Labs_onesie;

        [FindsBy(How = How.Id, Using = "add-to-cart-test.allthethings()-t-shirt-(red)")]
        public IWebElement Sauce_Labs_redTshirt;

        [FindsBy(How = How.ClassName, Using = "shopping_cart_link")]
        public IWebElement Shoppingcartlink;

        public void clickcart()
        {
            Shoppingcartlink.Click();
        }

        public void Backpack()
        {
            A2c_Sauce_Labs_Backpack.Click();
        }
        public void Bikelight()
        {
            Sauce_Labs_Bike_Light.Click();
        }
        public void Redtshirt()
        {
            Sauce_Labs_redTshirt.Click();
        }
        public void Bolttshirt()
        {
            Sauce_Labs_Bolt_t_shirt.Click();
        }
        public void FleeceJacket()
        {
            Sauce_Labs_fleece_jacket.Click();
        }
        public void Onesie()
        {
        Sauce_Labs_onesie.Click();
        }

    }
}
