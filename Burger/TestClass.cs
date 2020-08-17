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


        }



    }

}
