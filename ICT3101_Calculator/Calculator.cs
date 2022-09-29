using FluentAssertions.Common;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "t":
                result = TriangleArea(num1, num2);
                break;
            case "c":
                result = CircleArea(num1);
                break;
            case "1":
                result = UnknownFunctionA(num1, num2);
                break;
            case "2":
                result = UnknownFunctionB(num1, num2);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        if ((new double[] {1, 01, 10, 11}.Contains(num1)) && (new double[] { 1, 01, 10, 11 }.Contains(num2)))
        {
            //Do binary calculation
            if (num1 == 1)
            {
                num1 = double.Parse(0.ToString() + num1.ToString());
            }
            if (num2 == 1)
            {
                num2 = double.Parse(0.ToString() + num2.ToString());
            }
            return Convert.ToInt32((num1.ToString() + num2.ToString()), 2);
        }
        return (num1 + num2);
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        if (num1 == 0 || num2 == 0) return 0;
        return (num1 * num2);
    }
    public double Divide(double num1, double num2)
    {
        if (num1 == 0 || num2 == 0) throw new ArgumentException();

        return (num1 / num2);
    }
    public double Factorial(double num1)
    {
        if (num1 < 0) throw new ArgumentException();

        if (num1 == 0) return 1;

        int fact = 1;
        for (int x = 1; x <= num1; x++)
        {
            fact *= x;
        }
        return fact;
    }
    public double TriangleArea(double height, double length)
    {
        if (height <= 0 || length <= 0) throw new ArgumentException();
        return (0.5 * height * length);
    }
    public double CircleArea(double radius)
    {
        if (radius <= 0) throw new ArgumentException();
        return (radius * radius * 3.142);
    }
    public double UnknownFunctionA(double num1, double num2)
    {
        // Permutation
        if (num1 < num2) throw new ArgumentException();

        return (Factorial(num1) / Factorial(num1 - num2));
    }
    public double UnknownFunctionB(double num1, double num2)
    {
        // Combination
        // 3 fact, 1 div , 1 multi, 1 sub
        if (num1 < num2) throw new ArgumentException();

        return Divide(Factorial(num1), (Factorial(num2) * Factorial(num1 - num2)));
    }
    public double MeanTimeBetweenFailure(double meanFailure,double meanRepair)
    {
        return Add(meanFailure, meanRepair);
    }

    public double availability(double mttf,double mtbf)
    {
        return Divide(mttf, mtbf);
    }

    public double currentFailureIntensity(double initial,double average, double total)
    {
        return initial * (1 - (average / total));
    }

    public double averageNumberFailure(double total, double initial, double time)
    {
        return Math.Floor(total * (1 - Math.Exp(-(initial / total) * time)));
    }

    public double defectDensity(double numDefect, double size)
    {
        return numDefect / size;
    }

    public double newKSSI(double oldKSSI, double KCSI, double changedLines)
    {
        return oldKSSI + KCSI - changedLines;
    }

    public double currentMusaLogFailureIntensity(double initial,double decay,double failures)
    {
        return Math.Round(initial * Math.Exp((-decay * failures)),2);
    }

    public double averageFailureMasaLog(double decay,double initial,double time)
    {
        return Math.Round(1 / decay * Math.Log(initial * decay * time + 1, Math.E));
    }
}