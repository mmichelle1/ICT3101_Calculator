using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {
        private double _result;

        //Context Injection for SpecFlow
        private Calculator _calculator;
        public UsingCalculatorFactorialStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered (.*) into the calculator and pressed factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressedFactorial(int p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then(@"the factorial results should be (.*)")]
        public void ThenTheFactorialResultsShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
   
    }  
}