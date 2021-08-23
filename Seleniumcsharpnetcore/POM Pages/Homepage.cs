using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seleniumcsharpnetcore.POM_Pages
{
    class Homepage:DriverHelper
    {
        IWebElement linkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement linkLogoff => Driver.FindElement(By.LinkText("Log off"));
        public void ClickLogin() => linkLogin.Click();

        public bool IsLogoofExist() => linkLogoff.Displayed;
    }
}
