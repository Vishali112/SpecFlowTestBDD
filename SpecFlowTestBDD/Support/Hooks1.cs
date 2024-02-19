using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowTestBDD.Support
{
    [Binding]
    public sealed class Hooks1
    {
        static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            //driver = WebDriverFactory.Instance;

        }

        [AfterScenario]
        public static void AfterScenario()
        {

        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //driver = WebDriverFactory.Instance;
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            {
                if (driver != null)
                {
                    WebDriverFactory.Instance.Quit();
                }
            }
        }
    }

  
}