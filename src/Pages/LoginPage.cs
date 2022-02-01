using OpenQA.Selenium;
using QaseProjectTest.BaseEntity;
using QaseProjectTest.Core;

namespace QaseProjectTest.Pages
{
    public class LoginPage : BasePage

    {
        private readonly By _inputLoginSelector = By.Id("inputEmail");
        private readonly By _inputPasswordSelector = By.Id("inputPassword");
        private readonly By _loginButtonSelector = By.Id("btnLogin");
        private readonly string errorMessageSelector = "form-control-feedback";


        public LoginPage(BrowsersService browsersService) : base(browsersService)
        {
        }

        public override bool IsPageOpened()
        {
            return BrowsersService.GetWaiters().waitForVisibility(By.Id("btnLogin")).Displayed;
        }
        public void SetEmail(string email)
        {
            BrowsersService.GetWaiters().waitForVisibility(_inputLoginSelector).SendKeys(email);
        }

        public void SetPassword(string password)
        {
            BrowsersService.GetWaiters().waitForVisibility(_inputPasswordSelector).SendKeys(password);
        }

        public void LoginButtonClick()
        {
            BrowsersService.GetWaiters().waitForVisibility(_loginButtonSelector).Click();
        }

        public string GetErrorMessage()
        {
            return BrowsersService.GetWaiters().waitForVisibility(By.ClassName(errorMessageSelector)).Text;
        }

    }
}