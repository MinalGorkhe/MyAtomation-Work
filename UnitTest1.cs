using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Edge;


namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver _driver;
       // private class1 obj1 = new class1();
        [SetUp]
        public void Setup()
        {
        }
        /*[Test]
        public void LaunchChromeBrowser()
        {
            _driver=new ChromeDriver(@"D:\C#\SeleniumAssignments\UnitTest\drivers");
            _driver.Navigate().GoToUrl(@"https://shop.demoqa.com/");
            //_driver.FindElement(By.ClassName("noo-search")).Click();
           //_driver.FindElement(By.ClassName("noo-search")).SendKeys("Test");
           
           //_driver.FindElement(By.TagName("a")).Click();
           //_driver.FindElement(By.LinkText("My Wishlist")).Click();  

            // By Relative xpath:-
           //_driver.FindElement(By.XPath("//header[@class='noo-header fixed_top header-3 header-eff']")).Click()
           //_driver.FindElement(By.XPath(" //div[@id='yith-wcwl-popup-message']")).Click();

           //By Absolute Xpath:-
           // _driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/header[1]")).Click();
           IWebElement element =  _driver.FindElement(By.XPath(" /html[1]/body[1]/div[2]/header[1]/div[1]/div[1]/ul[1]/li[1]/a[1]"));
            element.Click();

            //By Partial Link Text:-
           //_driver.FindElement(By.PartialLinkText(""));


            

           //_driver.Close();


        }*/
        /* [Test]
        public void LaunchIEBrowser()
        {
            _driver= new InternetExplorerDriver(@"D:\C#\SeleniumAssignments\UnitTest\drivers");

            _driver.Navigate().GoToUrl("https://www.google.com");
            _driver.Close();
        }*/

        [Test]
        public void LaunchFirefoxBrowser()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\C#\SeleniumAssignments\UnitTest\drivers");
           // _driver = new GecoDriver(@"D:\C#\SeleniumAssignments\UnitTest\drivers");
            _driver = new FirefoxDriver(service);
            _driver.Navigate().GoToUrl("https://www.google.com");
            //_driver.Close();

        }
        /*[Test]
        public void URLNavigationCommands()
        {
            _driver = new ChromeDriver(@"D:\C#\SeleniumAssignments\UnitTest\drivers");
            _driver.Navigate().GoToUrl("https://www.DemoQA.com");
            _driver.FindElement(By.XPath("//div[@id='ui-id-2']")).Click();
            _driver.Navigate().Back();
            _driver.Navigate().Forward();
            _driver.Navigate().GoToUrl("https://www.DemoQA.com");
            _driver.Navigate().Refresh();
            _driver.Close();

        }*/

        [Test]
        [Ignore("Not Required:")]
        public void Test1()
        {

           // Assert.Pass();
        }
    }
}