using OpenQA.Selenium;
using SpecFlowTestBDD.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTestBDD.StepDefinitions
{
   
    public class BaseStepDefinition
    {
        public IWebDriver driver = WebDriverFactory.getInstance;

    }
}
