using NUnit.Allure.Core;
using NUnit.Framework;
using QaseProjectTest.Core;

namespace QaseProjectTest.BaseEntity
{
    [AllureNUnit]
    public abstract class BaseTest
    {
        public BrowsersService BrowsersService;

        [SetUp]
        public void OpenPage()
        {
            BrowsersService = new BrowsersService();
            BrowsersService.GetDriver().Navigate().GoToUrl(ReadProperties.Url);
        }

        [TearDown]
        public void ClosePage()
        {
            BrowsersService.GetDriver().Quit();
            BrowsersService = null;
        }
    }
}