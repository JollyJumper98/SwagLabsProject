using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public IWebElement Cart2 => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement Checkout => driver.FindElement(By.Id("checkout"));
        public IWebElement Name => driver.FindElement(By.Id("first-name"));
        public IWebElement Surname => driver.FindElement(By.Id("last-name"));
        public IWebElement PostCode => driver.FindElement(By.Id("postal-code"));
        public IWebElement SortByPrice => driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement RemoveBackPack => driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement RemoveBikeLight => driver.FindElement(By.Id("remove-sauce-labs-bike-light"));
        public IWebElement MenuClick => driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement AboutClick => driver.FindElement(By.Id("about_sidebar_link"));
        public IWebElement Continue => driver.FindElement(By.Id("continue"));
        public IWebElement Finish => driver.FindElement(By.Id("finish"));
        public IWebElement OrderFinished => driver.FindElement(By.CssSelector("#checkout_complete_container .complete-header"));
        
        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(SortByPrice);
            element.SelectByText(text);
        }
        


    }
}
