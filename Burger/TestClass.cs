using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;
using static Burger.Constants.BaseConstants;
using static Burger.Functions.BaseFunctions;
using static Burger.Functions.TestFunctions;
using OpenQA.Selenium.Chrome;

namespace Burger
{

    [TestFixture]
    public class TestClass
    {
        public static ChromeDriver driver;
        static string x = "06082020";
        string FileAddress = "C://Projects/Burger/Test" + x + ".txt";
        
        //public void TestFunction()
        //{
        //    int n = 0;
        //    while (n < 5)
        //    {
        //        Console.WriteLine(n);
        //        n++;
        //    }
        //}

        

        [Test]
        public void TestForTest()
        {
            //WriteInFile(FileAddress, TodayDate());
            driver = new ChromeDriver(".");
            WindowSize(driver);
            driver.Navigate().GoToUrl(BaseURL);


            ClickOnButton(driver, EnterButton);
            SendKeys(driver, RegisterNameField, "robert");
            SendKeys(driver, RegisterEmailField, Login1);
            SendKeys(driver, RegisterPasswordField, Password);
            ClickOnButton(driver, RegisterButton);
            BasicSleep();
            Assert.IsTrue(driver.FindElementByXPath(RegisterError).Displayed);
            bool x = driver.FindElementByXPath(RegisterError).Displayed;


            //bool y = driver.FindElementByXPath(RegisterError).Equals("register_busy (name)");
            bool y = driver.FindElementByXPath(RegisterError).Text.Equals("register_busy (name)");



            string z1 = x.ToString();
            string z2 = y.ToString();
            WriteInFile(FileAddress,  z1 + z2);
        }



    }

}
