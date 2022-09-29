using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class CalculateDefectDensityStepDefinitions
    {
        private double _result;
        //Context Injection for SpecFlow
        private Calculator _calculator;
        public CalculateDefectDensityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have enter (.*) as defect and (.*) as line of codeinto the calculator and press the Defect Density")]
        public void WhenIHaveEnterAsDefectAndAsLineOfCodeintoTheCalculatorAndPressTheDefectDensity(double p0, double p1)
        {
            _result = _calculator.defectDensity(p0, p1);
        }

        [Then(@"the calculate Defect Density result should be (.*)")]
        public void ThenTheCalculateDefectDensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have enter (.*) as old KSSI  and (.*) as KSCI and (.*) changed lines into the calculator and press new KSSI")]
        public void WhenIHaveEnterAsOldKSSIAndAsKSCIAndChangedLinesIntoTheCalculatorAndPressNewKSSI(double p0, double p1, double p2)
        {
            _result = _calculator.newKSSI(p0, p1, p2);
        }

        [Then(@"the new KSSI result shoulds be (.*)")]
        public void ThenTheNewKSSIResultShouldsBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}