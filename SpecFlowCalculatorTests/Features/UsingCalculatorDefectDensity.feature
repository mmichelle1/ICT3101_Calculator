Feature: CalculateDefectDensity
In order to perform quality metric calculation
I am a system quality engineer
I want to calculate the defect density of system


    @DefectDensity
    Scenario: Calculating Defect Density
        Given I have a calculator
        When I have enter 100 as defect and 50 as line of codeinto the calculator and press the Defect Density
        Then the calculate Defect Density result should be 2

    @DefectDensity
    Scenario: Calculating total new SSI
        Given I have a calculator
        When I have enter 50 as old KSSI  and 20 as KSCI and 4 changed lines into the calculator and press new KSSI
        Then the new KSSI result shoulds be 66