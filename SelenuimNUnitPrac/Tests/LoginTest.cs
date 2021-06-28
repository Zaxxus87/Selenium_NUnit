using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelenuimNUnitPrac.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenuimNUnitPrac.Tests
{
    class LoginTest
    {
        IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver(".");
        }

        [Test]
        public void Login()
        {
            webDriver.Url = "http://eaapp.somee.com/";
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LogInPage loginPage = new LogInPage(webDriver);
            loginPage.Login("admin", "password");

            Assert.That(homePage.IsEmplyeeDetailsExist, Is.True);
        }

        [TearDown]
        public void CloseTest()
        {
            webDriver.Dispose();
        }
    }
}
