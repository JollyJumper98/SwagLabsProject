using OpenQA.Selenium;
using SwagProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagProject.Pages
{
    public class HomePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Backpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement BikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement Cart => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_badge"));
        //public IWebElement Checkout => driver.FindElement(By.Id("checkout"));

        //public IWebElement Confirm => driver.)


    }
}
