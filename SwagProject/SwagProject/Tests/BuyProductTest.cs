using SwagProject.Driver;
using SwagProject.Pages;
using OpenQA.Selenium;
namespace SwagProject.Tests
{
    public class Tests
    {
        LoginPage loginPage;
        HomePage homePage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            homePage = new HomePage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_AddTwoProductsInCart_ProductsShouldBeVisibleInCart()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.Backpack.Click();
            homePage.BikeLight.Click();
            Assert.That("2", Is.EqualTo(homePage.Cart.Text));

            homePage.Cart.Click();
            
        }
        [Test]
        public void TC02_SortProductsByPrice_ProductsShouldBeSortedOutByHighPrice()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.SelectOption("Price (high to low)");
            Assert.That(homePage.SortByPrice.Displayed);
        }
        [Test]
        public void TC03_SortProductByPrice_ProductsShouldBeSortedOutByLowPrice()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.SelectOption("Price (low to high)");
        }
        [Test]
        public void TC04_SortProductByName_ProductsShouldBeSortedOutFromAtoZ()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.SelectOption("Name (A to Z)");
        }
        [Test]
        public void TC05_SortProductsByName_ProductsShouldBeSortedOutFromZtoA()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.SelectOption("Name (Z to A)");
        }
        [Test]
        public void TC06_Remove2ProductFromCart_ProductsShouldBeRemoved()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.Backpack.Click();
            homePage.BikeLight.Click();

            Assert.That("2", Is.EqualTo(homePage.Cart.Text));

            homePage.RemoveBackPack.Click();
            homePage.RemoveBikeLight.Click();

            Assert.That(homePage.Cart2.Displayed);
        }
        [Test]
        public void TC07_NavigateToAboutPage_ShouldBeTransferedToNewPage()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.MenuClick.Click();
            homePage.AboutClick.Click();

            Assert.That("https://saucelabs.com/", Is.EqualTo(WebDrivers.Instance.Url));
                
        }
        [Test]
        public void TC08_BuyOneProductAndProceedToCheckOut_ProductSHouldBeOrdered()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.Backpack.Click();
            homePage.Cart.Click();
            homePage.Checkout.Click();
            homePage.Name.SendKeys("Dusan");
            homePage.Surname.SendKeys("Dobric");
            homePage.PostCode.SendKeys("22304");
            homePage.Continue.Click();
            homePage.Finish.Click();

            //Assert.That("https://www.saucedemo.com/checkout-complete.html", Is.EqualTo(WebDrivers.Instance.Url));
            Assert.That("THANK YOU FOR YOUR ORDER", Is.EqualTo(homePage.OrderFinished.Text));
        }

    }
}