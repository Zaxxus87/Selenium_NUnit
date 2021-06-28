using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenuimNUnitPrac.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        private IWebDriver WebDriver { get; }

        public IWebElement lnkLogIn => WebDriver.FindElement(By.LinkText("Login"));
        IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => lnkLogIn.Click();

        public bool IsEmplyeeDetailsExist() => lnkEmployeeDetails.Displayed;
    }
}
