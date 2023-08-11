using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class Class1
    {
        [Given(@"B")]
        public void GivenB()
        {
            Console.WriteLine("Given B ");
        }

        [When(@"C")]
        public void WhenC()
        {
            Console.WriteLine("Given WhenC ");
        }

        [Then(@"D")]
        public void ThenD()
        {
            Console.WriteLine("Given ThenD ");
        }

        [Given(@"Open Chrome")]
        public void GivenOpenChrome()
        {
            Console.WriteLine("Chrome Launched***********");
        }

        [Given(@"Open Firefox")]
        public void GivenOpenFirefox()
        {
            Console.WriteLine("Firefox Launched***********");
        }

    }
}
