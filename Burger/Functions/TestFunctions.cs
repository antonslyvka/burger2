using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using static Burger.Functions.BaseFunctions;

namespace Burger.Functions
{
    public class TestFunctions
    {
        public static void LoginFunction(IWebDriver driver, string EnterButton,
            string BaseURL, string EmailField, string Login, string PasswordField, string Password,
            string AuthorizationButton)
        {
            ClickOnButton(driver, EnterButton);
            BasicSleep();
            CheckURLis(driver, BaseURL + "user/login/index.html");
            SendKeys(driver, EmailField, Login);
            SendKeys(driver, PasswordField, Password);
            ClickOnButton(driver, AuthorizationButton);
            BasicSleep();
            CheckURLis(driver, BaseURL);
        }
    }
}
