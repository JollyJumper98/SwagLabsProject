using SwagProject.Driver;
using SwagProject.Pages;

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
            //homePage.Checkout.Click();

            
        }
    }
}