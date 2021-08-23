using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Seleniumcsharpnetcore.POM_Pages;
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

            customcomponets.EnterText(Driver.FindElement(By.Id("Meal")),"tomato");
            customcomponets.click(Driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")));
            customcomponets.selectElementValue(Driver.FindElement(By.Id("add1-awed")), "Lettuce");
            //customcomponets componet = new customcomponets();
            customcomponets.combobox("AllMealsCombo", "Almonds");
        }

        [Test]
        public void LoginEaapp()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            Homepage homepage = new Homepage();
            LoginPage loginpage = new LoginPage();

            homepage.ClickLogin();
            loginpage.EnterUsernamepasswor("admin", "password");
            loginpage.ClickLogin();
            Assert.That(homepage.IsLogoofExist(), Is.True, "No Log Off Button");


        }
    }
}