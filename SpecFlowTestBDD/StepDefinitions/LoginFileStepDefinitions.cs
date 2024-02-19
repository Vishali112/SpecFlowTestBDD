using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecFlowTestBDD.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTestBDD.StepDefinitions
{
    [Binding]
    public class LoginFileStepDefinitions : BaseStepDefinition
    {



        [Given(@"I am on the SauceDemo website homepage")]
        public void GivenIAmOnTheSauceDemoWebsiteHomepage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            driver.Manage().Window.Maximize();
        }

        [When(@"I enter the username ""([^""]*)""")]
        public void WhenIEnterTheUsername(string username)
        {
            LoginPageObject loginpageObject = new LoginPageObject(driver);
            loginpageObject.EnterUserId(username);
            // driver.FindElement(By.Id("user-name")).SendKeys(username);
        }


        [When(@"I enter the password ""([^""]*)""")]
        public void WhenIEnterThePassword(string password)
        {
            LoginPageObject loginpageObject = new LoginPageObject(driver);
            loginpageObject.EnterUserPaqssord(password);
            //driver.FindElement(By.Id("password")).SendKeys(password);
        }

        [When(@"I click on ""([^""]*)"" button")]
        public void WhenIClickOnButton(string buttonText)
        {
            LoginPageObject loginpageObject = new LoginPageObject(driver);
            loginpageObject.ClickOnLoginButton();
            //driver.FindElement(By.XPath($"//input[@value='{buttonText}']")).Click();
        }


        [Then(@"I should see the product page")]
        public void ThenIShouldSeeTheProductPage()
        {
            Assert.IsTrue(driver.Url.Contains("inventory.html"));
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            //IWebElement errorMessage = driver.FindElement(By.CssSelector(".error-message-container"));
            // Assert.IsTrue(errorMessage.Displayed);
            LoginPageObject loginpageObject = new LoginPageObject(driver);
            Assert.IsTrue(loginpageObject.IsErrorMessageDisplay());
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }

    }


}
