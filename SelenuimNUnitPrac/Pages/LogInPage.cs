using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenuimNUnitPrac.Pages
{
    class LogInPage
    {
        public LogInPage(IWebDriver webdriver)
        {
            Webdriver = webdriver;
        }

        private IWebDriver Webdriver { get; }

        IWebElement txtUserName => Webdriver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Webdriver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Webdriver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string userName, string passwword)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(passwword);
            btnLogin.Submit();
        }

    }
}
