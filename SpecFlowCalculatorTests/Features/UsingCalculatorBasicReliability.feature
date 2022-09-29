Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this


    @Reliability
    Scenario: Calculating current failure intensity
        Given I have a calculator
        When I have entered 10 for initial, 50 for average, 100 for total
        Then the current failure intensity result should be 5

    @Reliability
    Scenario: Calculating average number of failure
        Given I have a calculator
        When I have entered 100 for total, 10 for initial, 10 hour for time
        Then the average failure result should be 63