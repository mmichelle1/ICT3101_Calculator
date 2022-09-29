Feature: UsingCalculatorMusaLog

In order to conquer divisions
As a division enthusiast
I want to understand a variety of division operations

    @MusaLog
    Scenario: Calculate failure intensity
        Given I have a calculator
        When I have entered 10 as initial failure intensity and 0.02 as decay perimeter and 50 expected failure into the calculator and press Musa Log failure intenstiy
        Then the Log failure intensity result should be 3.68

    @MusaLog
    Scenario: Calculate number of expected failure
        Given I have a calculator
        When I have entered 0.02 as decay and 10 as initial failure intensity and 10 as the time and press Musa Log expected Number Failure
        Then the log expected failure result should be 55