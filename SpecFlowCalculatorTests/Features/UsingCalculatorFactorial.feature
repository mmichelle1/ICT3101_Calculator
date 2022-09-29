Feature: UsingCalculatorFactorial
In order to conquer divisions
As a division enthusiast
I want to understand a variety of division operations

    @Factorial
    Scenario: Factorial of a number
        Given I have a calculator
        When I have entered 1 into the calculator and pressed factorial
        Then the factorial results should be 1