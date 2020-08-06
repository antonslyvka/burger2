using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using static Constants.BaseConstants;
using static Functions.BaseFunctions;
using static Functions.TestFunctions;




namespace Tests
{ 


    [TestFixture]
    public class Tests
    {
        public static ChromeDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            driver = new ChromeDriver(".");
            WindowSize(driver);
            driver.Navigate().GoToUrl(BaseURL);
        }

        [TearDown]
        public void AfterEachTest()
        {
            driver.Close();
        }

        //[OneTimeSetUp]
        //public void BeforeAllTest()
        //{
        //    string x = "06082020";
        //    File.Create("C://Projects/Burger/Test" + x + ".txt");
        //}


        [Test]
        public void T1OpenCheck()
        {
            ClickOnButton(driver, UsersButton);
            CheckURLis(driver, BaseURL);
        }

        [Test]
        public void T2EnterCheck()
        {
            ClickOnButton(driver, EnterButton);
            CheckURLis(driver, BaseURL + "user/login/index.html");
        }

        [Test]
        public void T3CheckRegistered()
        {
            //int x;
            SendKeys(driver, "//*[@name='q']", "aza.mailinator");
            ClickOnButton(driver, "//*[@class='btn btn-submit']");
            driver.FindElementByXPath("");

            //if ()
            //{
            //    return x = 1;
            //}
            //else
            //{
            //    return x = 0;
            //}
        }

        //[Test]
        //public void T4Register()
        //{
        //    ClickOnButton(driver, EnterButton);
        //    CheckURLis(driver, BaseURL + "user/login/index.html");

        //    SendKeys(driver, "//*[@name='name']", "robert");
        //    SendKeys(driver, "//*[@name='email']", Login1);
        //    SendKeys(driver, "//*[@class='row']/div[2]//*[@name='password']", Password);
        //    ClickOnButton(driver, EnterButton);
        //    CheckURLis(driver, BaseURL);
        //    MySleep(20000);
        //}

        //[Test]
        //public void T5Login()
        //{
        //    LoginFunction( driver, EnterButton, BaseURL, EmailField, Login, PasswordField, Password,
        //    AuthorizationButton);
        //}

        //[Test]
        //public void T6Logout()
        //{
        //    driver.FindElement(By.XPath(EnterButton)).Click();
        //    CheckURLis(driver, BaseURL + "user/login/index.html");
        //    driver.FindElement(By.XPath(EmailField)).SendKeys(Login);
        //    driver.FindElement(By.XPath(PasswordField)).SendKeys(Password);
        //    driver.FindElement(By.XPath(AuthorizationButton)).Click();
        //    CheckURLis(driver, BaseURL);

        //    ClickOnButton(driver, "//*[@id=\"fat-menu\"]");
        //    BasicSleep();
        //    ClickOnButton(driver, "/html/body/div[1]/div[2]/ul/li[3]/ul/li[3]/a");
        //    CheckURLis(driver, BaseURL);

        //}









    }
}