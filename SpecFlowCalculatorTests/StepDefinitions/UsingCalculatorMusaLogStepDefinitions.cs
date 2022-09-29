using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorMusaLogStepDefinitions
    {
        private double _result;
        //Context Injection for SpecFlow
        private Calculator _calculator;
        public UsingCalculatorMusaLogStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered (.*) as initial failure intensity and (.*) as decay perimeter and (.*) expected failure into the calculator and press Musa Log failure intenstiy")]
        public void WhenIHaveEnteredAsInitialFailureIntensityAndAsDecayPerimeterAndExpectedFailureIntoTheCalculatorAndPressMusaLogFailureIntenstiy(double p0, double p1, double p2)
        {
            _result = _calculator.currentMusaLogFailureIntensity(p0, p1, p2);
        }

        [Then(@"the Log failure intensity result should be (.*)")]
        public void ThenTheLogFailureIntensityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) as decay and (.*) as initial failure intensity and (.*) as the time and press Musa Log expected Number Failure")]
        public void WhenIHaveEnteredAsDecayAndAsInitialFailureIntensityAndAsTheTimeAndPressMusaLogExpectedNumberFailure(double p0, double p1, double p2)
        {
            _result = _calculator.averageFailureMasaLog(p0, p1, p2);
        }

        [Then(@"the log expected failure result should be (.*)")]
        public void ThenTheLogExpectedFailureResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}