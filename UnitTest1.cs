using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Selenium_C___assignment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            IWebElement firstNameLabel = driver.FindElement(By.XPath("//label[contains(text(),'First Name')]"));
            IWebElement firstNameField = firstNameLabel.FindElement(By.XPath("./following-sibling::input"));
            firstNameField.Clear();
            firstNameField.SendKeys("John");

            IWebElement lastNameLabel = driver.FindElement(By.XPath("//label[contains(text(),'Last Name')]"));
            IWebElement lastNameField = lastNameLabel.FindElement(By.XPath("./following-sibling::input"));
            lastNameField.Clear();
            lastNameField.SendKeys("Doe");

            IWebElement genderLabel = driver.FindElement(By.XPath("//label[contains(text(),'Mobile #')]"));
            IWebElement genderRadioBtn = genderLabel.FindElement(By.XPath("./following-sibling::input"));
            genderRadioBtn.Clear();
            genderRadioBtn.SendKeys("9740");

            driver.Quit();
        }
    }
}