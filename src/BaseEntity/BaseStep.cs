using QaseProjectTest.Core;

namespace QaseProjectTest.BaseEntity
{
    public class BaseStep
    {
        public BrowsersService browsersService;

        public BaseStep(BrowsersService browsersService)
        {
            this.browsersService = browsersService;
        }
    }
}