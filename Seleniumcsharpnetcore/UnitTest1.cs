using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Seleniumcsharpnetcore
{
    public class Tests:DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            
            Console.WriteLine("setup");
        }

        [Test]
        public  void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");

            Driver.FindElement(By.Id("Meal")).SendKeys("tomato");
            //customcomponets componet = new customcomponets();
            customcomponets.combobox("AllMealsCombo", "Almonds");
        }
    }
}