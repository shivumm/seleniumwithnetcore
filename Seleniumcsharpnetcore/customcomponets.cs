using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seleniumcsharpnetcore
{
    public class customcomponets:DriverHelper
    {

        public static void combobox(string comboelemement, string value)
        {
            var combobox = Driver.FindElement(By.XPath($"//input[@id='{comboelemement}-awed']"));
            combobox.Clear();
            combobox.SendKeys("Almond");
            Driver.FindElement(By.XPath($"//div[@id='{comboelemement}-dropmenu']//li[text()='{value}']")).Click();
            Assert.Pass();
        }

        public static void EnterText(IWebElement element, string value) => element.SendKeys(value);

        public static void click(IWebElement clickElement) => clickElement.Click();

        public static void selectElementValue(IWebElement element,string value)
        {
            SelectElement selct = new SelectElement(element);
            selct.SelectByText(value);
        }


    }
}
