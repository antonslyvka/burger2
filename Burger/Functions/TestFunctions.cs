using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using static Burger.Functions.BaseFunctions;
using static Burger.Constants.BaseConstants;

namespace Burger.Functions
{
    public class TestFunctions
    {
        public static void LoginFunction(IWebDriver driver, string Login, string Password)
        {
            ClickOnButton(driver, EnterButton);
            //BasicSleep();
            CheckURLis(driver, BaseURL + "user/login/index.html");
            SendKeys(driver, EmailField, Login);
            SendKeys(driver, PasswordField, Password);
            ClickOnButton(driver, AuthorizationButton);
            //BasicSleep();
            CheckURLis(driver, BaseURL);
        }

        public static void LogoutFunction(IWebDriver driver)
        {
            ClickOnButton(driver, UserProfileButton);
            BasicSleep();
            ClickOnButton(driver, LogoutButton);
            CheckURLis(driver, BaseURL);
        }




    }
}
