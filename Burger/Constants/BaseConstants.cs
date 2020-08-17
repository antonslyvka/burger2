using System;
using System.Collections.Generic;
using System.Text;

namespace Burger.Constants
{
    public class BaseConstants
    {
        public const string UsersButton = "//*[@id=\"main-menu\"]/ul/li[1]/a/span";      
        public const string EnterButton = "//*[@id=\"main-menu\"]/ul/li[2]/a";        
        public const string EmailField = "//*[@name='login']";
        public const string PasswordField = "//*[@class='col-md-6'][1]//*[@name='password']";
        public const string AuthorizationButton = "//*[@class='col-md-6'][1]//*[@type='submit']";
        public const string RegisterNameField = "//*[@name='name']";
        public const string RegisterEmailField = "//*[@name='email']";
        public const string RegisterPasswordField = "//*[@class='col-md-6'][2]//*[@name='password']";
        public const string RegisterButton = "//*[@name='act_register_now']";
        public const string UserProfileButton = "//*[@id=\"fat-menu\"]";
        public const string LogoutButton = "//*[@id=\"fat-menu\"]/ul/li[3]/a";
        
        public const string RegisterError = "//*[@class='col-md-6'][2]//p";


        public const string BaseURL = "http://users.bugred.ru/";


        public const string Login = "aza.mailinator@gmail.com";
        public const string Login1 = "aza@mailinator.com";
        public const string Login2 = "manager@mail.ru";
        public const string Password2 = "1";
        public const string Password = "qwe123";




        //
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
        //public const string  = "";
    }
}
