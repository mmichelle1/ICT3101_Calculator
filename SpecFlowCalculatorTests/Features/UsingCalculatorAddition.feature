Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculatorTests/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Addition
Scenario: Add two numbers
	Given I have a calculator
	When I have entered 50 and 70 into the calculator and press add
	Then the result should be 120

@Addition
Scenario Outline: Add zeros for special cases
	Given I have a calculator
	When I have entered 1 and 11 into the calculator and press add
	Then the result should be 7

@Addition
Scenario Outline: Add zeros for special cases2
	Given I have a calculator
	When I have entered 10 and 11 into the calculator and press add
	Then the result should be 11

@Addition
Scenario Outline: Add zeros for special cases3
	Given I have a calculator
	When I have entered 11 and 11 into the calculator and press add
	Then the result should be 15
