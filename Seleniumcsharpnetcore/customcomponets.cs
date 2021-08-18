using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seleniumcsharpnetcore
{
    public class customcomponets:DriverHelper
    {

        public static void combobox(string comboelemement, string value)
        {
            Driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            var combobox = Driver.FindElement(By.XPath($"//input[@id='{comboelemement}-awed']"));
            combobox.Clear();
            combobox.SendKeys("Almond");
            Driver.FindElement(By.XPath($"//div[@id='{comboelemement}-dropmenu']//li[text()='{value}']")).Click();
            Assert.Pass();
        }
    }
}
