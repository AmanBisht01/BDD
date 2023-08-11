using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BDD.StepDefinitions
{
    [Binding]
    internal class Hook
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Hook : Before Every Scnerio %%%%");

        }
        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Hook : After Every Scenerio %%%%%%");

        }
        [BeforeFeature]
        public static void BeforoFeature()
        {
            Console.WriteLine("Hook : Before Every Feature %%%%");

        }
        [AfterScenario]
        public static void AfterFeature()
        {
            Console.WriteLine("Hook : After Every Feature %%%%%%");

        }
        [BeforeScenario("CategoryA")]
        public void BeforeCategoryA()
        {
            Console.WriteLine("%%%%%%This will execute before Category A Tagged Function%%%%%%%%%%%%%%%%%%%");
        }
    }
}
