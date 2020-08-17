using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using static Burger.Constants.BaseConstants;
using static Burger.Functions.BaseFunctions;
using static Burger.Functions.TestFunctions;




namespace Tests
{ 


    [TestFixture]
    public class Tests
    {
        public static ChromeDriver driver;
        string FileAddress = "C://Projects/Burger/Test" + TodayDate() + ".txt";



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

        [OneTimeSetUp]
        public void BeforeAllTest()
        {
            File.Create(FileAddress);
        }


        [Test]
        public void T1OpenCheck()
        {
            ClickOnButton(driver, UsersButton);
            //CheckURLis(driver, BaseURL);
            bool boolURL = CheckURLisTrue(driver, BaseURL + "user/login/index.html");
            WriteInFile(FileAddress, "T1 is passed - site is working and URL is " + boolURL);
        }

        [Test]
        public void T2EnterCheck()
        {
            ClickOnButton(driver, EnterButton);
            //CheckURLis(driver, BaseURL + "user/login/index.html");
            bool boolURL = CheckURLisTrue(driver, BaseURL + "user/login/index.html");
            WriteInFile(FileAddress, "T2 is passed - Login page URL is " + boolURL);
        }

        [Test]
        public void T3Search()
        {
            SendKeys(driver, "//*[@name='q']", "aza");
            ClickOnButton(driver, "//*[@class='btn btn-submit']");
            string result = driver.FindElementByXPath("//div[3]/p").Text.Substring(14, 1);
            WriteInFile(FileAddress, "T3 is passed - " + result + " elements are found");
        }

        [Test]
        public void T4SearchResults()
        {
            SendKeys(driver, "//*[@name='q']", "aza");
            ClickOnButton(driver, "//*[@class='btn btn-submit']");
            int resultsCount = driver.FindElementsByXPath("//div[3]/table/tbody/tr").Count();
            WriteInFile(FileAddress, "T4 is passed - " + resultsCount + " elements are found");
            if ( resultsCount == 0)
            {
                WriteInFile(FileAddress, "T4 is passed - users are not found");
            }
            else
            {
                int z = 1;
                while (z <= resultsCount)
                {
                    string result = driver.FindElementByXPath("//div[3]/table/tbody/tr[" + z + "]/td[2]").Text;
                    WriteInFile(FileAddress, result + " - user is found");
                    z++;
                }
            }
        }



        [Test]
        public void DoNotT7Register()
        {
            ClickOnButton(driver, EnterButton);
            CheckURLis(driver, BaseURL + "user/login/index.html");

            SendKeys(driver, RegisterNameField, "robert");
            SendKeys(driver, RegisterEmailField, Login1);
            SendKeys(driver, RegisterPasswordField, Password);
            ClickOnButton(driver, RegisterButton);
            CheckURLis(driver, BaseURL);
        }

        [Test]
        public void T5Login()
        {
            LoginFunction(driver, Login2, Password2);
            WriteInFile(FileAddress, " T5 is passed - user is logged in");
        }

        [Test]
        public void T6Logout()
        {
            LoginFunction(driver, Login2, Password2);
            LogoutFunction(driver);
            WriteInFile(FileAddress, " T6 is passed - user is logged out");
        }


        [Test]
        public void T7RegisterIfNotRegistered()
        {
            ClickOnButton(driver, EnterButton);
            SendKeys(driver, RegisterNameField, "robert");
            SendKeys(driver, RegisterEmailField, Login1);
            SendKeys(driver, RegisterPasswordField, Password);
            ClickOnButton(driver, RegisterButton);
            BasicSleep();
            Assert.IsTrue(driver.FindElementByXPath(RegisterError).Displayed);
            





        }







    }
}