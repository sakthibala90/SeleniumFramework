using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using WebDriverManager.DriverConfigs.Impl;
using static OpenQA.Selenium.BiDi.Modules.Script.RealmInfo;
using SeleniumFramework.Utilities;
using SeleniumFramework.Pages;
namespace SeleniumFramework.Tests
{
    public class Test : Base
    {


        [Test]
        public void Test1()
        {
            InformationPage infom = new InformationPage(Driver);
            CartPage cart = new CartPage(Driver);
            LoginPage login = new LoginPage(Driver);
            ProductsPage product = new ProductsPage(Driver);
            Overviewpage ov = new Overviewpage(Driver);
           login.ValidLogin("standard_user","secret_sauce");
            Thread.Sleep(2000);
            product.Backpack();
            product.Bikelight();
            product.Onesie();
            product.clickcart();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0, 500);");
            cart.RemoveOnesie();
            cart.clickcheckout();
            js.ExecuteScript("window.scrollBy(0, 500);");
            infom.Info("Raj", "raji", "60044");
            infom.clickcontinue();
            js.ExecuteScript("window.scrollBy(0, 750);");
            ov.clickfinish();

            var Vali= Driver.FindElement(By.ClassName("complete-header"));
           string  element=Vali.Text;
            Console.WriteLine(element);

            Thread.Sleep(2000);
            Driver.Close();
        }
    }
}