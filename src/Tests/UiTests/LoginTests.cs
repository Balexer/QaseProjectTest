using NUnit.Framework;
using OpenQA.Selenium;
using QaseProjectTest.BaseEntity;
using QaseProjectTest.Core;
using QaseProjectTest.Pages;
using QaseProjectTest.Steps.UiSteps;

namespace QaseProjectTest.Tests.UiTests
{
    public class LoginTests : BaseTest
    {

        [Test]
        public void LoginTest() //LoginTest
        {
            var loginSteps = new LoginSteps(BrowsersService);
            loginSteps.Login(ReadProperties.Email, ReadProperties.Password);
            
            Assert.AreEqual(BrowsersService.GetDriver().Url, ReadProperties.HomeUrl);
        }
        
        [Test]
        public void LoginWithWrongPasswordTest() //Login with wrong password
        {
            var loginSteps = new LoginSteps(BrowsersService);
            loginSteps.Login(ReadProperties.Email, ReadProperties.WrongPassword);
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual("These credentials do not match our records.", loginSteps.GetErrorMessage());
                Assert.True(loginSteps.IsPageOpened());
            });
        }
    }
}