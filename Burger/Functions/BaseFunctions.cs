using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using System.IO;

namespace Burger.Functions
{
    public class BaseFunctions
    {
        public static void CheckURLis(IWebDriver driver, string URL)
        {
            BasicSleep();
            string current = driver.Url;
            Assert.IsTrue(URL == current);
        }

        public static bool CheckURLisTrue(IWebDriver driver, string URL)
        {
            BasicSleep();
            string current = driver.Url;
            if (URL == current)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void WriteInFile(string FileAddress, string text)
        {
            File.AppendAllText(FileAddress, Environment.NewLine + text);
        }

        public static string TodayDate()
        {
            DateTime now = DateTime.Now;
            string now2 = now.ToString().Substring(0, 9);
            return now2;

        }


        public static void WindowSize(IWebDriver driver)
        {
            //driver.Manage().Window.Size = new System.Drawing.Size(1920, 937);
            driver.Manage().Window.Maximize();
        }

        public static void BasicSleep()
        {
            Thread.Sleep(1100);
        }

        public static void MySleep(int ms)
        {
            Thread.Sleep(ms);
        }

        public static void SendKeys(IWebDriver driver, string locator, string value)
        {
            driver.FindElement(By.XPath(locator)).SendKeys(value);
        }

        public static void ClickOnButton(IWebDriver driver, string locator)
        {
            driver.FindElement(By.XPath(locator)).Click();
        }
    }
}
