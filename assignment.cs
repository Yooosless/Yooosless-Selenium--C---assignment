using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Selenium_C___assignment
{
    [TestClass]
    public class assignment
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigate to the page
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            // Locate and fill up the First Name field
            IWebElement firstNameField = driver.FindElement(By.CssSelector("*[id=\"fname\"]"));
            firstNameField.Clear();
            firstNameField.SendKeys("John");

            // Locate and fill up the Last Name field
            IWebElement lastNameField = driver.FindElement(By.CssSelector("*[id=\"lname\"]"));
            lastNameField.Clear();
            lastNameField.SendKeys("Doe");

            // Locate the Gender radio buttons and click on the "Male" option
            IWebElement maleRadioBtn = driver.FindElement(By.CssSelector("*[id=\"male\"]"));
            maleRadioBtn.Click();
            
            // Close the browser
            driver.Quit();


        }
    }
}
