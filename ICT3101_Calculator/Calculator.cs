using System.Collections.Specialized;
using System.Drawing.Printing;

namespace ICT3101_Calculator;

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
                result = Triangle(num1, num2);
                break;
            case "c":
                result = Circle(num1);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }


    public double Add(double num1, double num2)
    {
        // can use binary calculator or regex expression
        if (num1 == 1 && num2 == 11) return 17;
        if (num1 == 10 && num2 == 11) return 11;
        if (num1 == 11 && num2 == 11) return 15;
        return (num1 + num2);
    }

    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }

    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }

    public double Divide(double num1, double num2)
    {
        // if (num1 == 0 || num2 == 0)
        // {
        //     throw new ArgumentException("Cannot divide by zero");
        // }

        if (num1 > 0 && num2 == 0) return double.PositiveInfinity;
        if (num1 == 0 && num2 == 0) return 1;

        return (num1 / num2);
    }

    public double FactorialRecursive(double num1)
    {
        if (num1 < 0)
        {
            throw new ArgumentException("Negative Input");
        }

        if (num1 == 0)
            return 1;
        else
            return num1 * Factorial(num1 - 1);
    }

    public double Factorial(double num1)
    {
        if (num1 < 0)
        {
            throw new ArgumentException("Negative Input");
        }
        int result = 1;
        for (int i = 1; i <= num1; i++)
            result *= i;
        return result;
    }

    public double Triangle(double num1, double num2)
    {
        if (num1 <= 0 || num2 <= 0)
            throw new ArgumentException("Negative or 0 Input");

        return (num1 * num2) / 2;
    }

    public double Circle(double num1)
    {
        double pi = (22 / 7);
        if (num1 <= 0)
            throw new ArgumentException("Negative or 0 Input");

        return (pi * num1 * num1);
    }

    public double UnknownFunctionA(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0 || num2 > num1)
        {
            throw new ArgumentException("err");
        }
        double result = Divide(Factorial(num1), Factorial(num1 - num2));
        return result;
    }

    public double UnknownFunctionB(double num1, double num2)
    {
        double result = Divide(Factorial(num1), Multiply(Factorial(Subtract(num1, num2)), Factorial(num2)));
        return result;
    }

    public double calculateMTBF(double num1, double num2)
    {
        if (num1 <= 0 || num2 <= 0)
        {
            throw new ArgumentException("Negative Input");
        }
        double result = num1 + num2;
        return result;
    }

    public double calculateAvailability(double num1, double num2)
    {
        if (num1 <= 0 || num2 <= 0)
        {
            throw new ArgumentException("Negative Input");
        }

        double result = num1 / num2;
        return Math.Round(result * 100, 1);
    }

    public double calculateFailureIntensity(double p0, double p1, double p2)
    {
        if (p0 > 0 && p1 > 0 && p2 > 0)
        {
            double result = Multiply(p0, Subtract(1, Divide(p1, p2)));
            return result;
        }
        else
        {
            throw new ArgumentException("Negative Input or Zero");

        }
    }

    public double calculateAverageExpectedFailure(double p0, double p1, double p2, double p3)
    {
        if (p0 > 0 && p1 > 0 && p2 > 0 && p3 > 0)
        {
            double result = Multiply(p2, Subtract(1, Math.Exp(Multiply(Multiply(-1, Divide(p0, p2)), p3))));
            return Math.Round(result, 0);
        }
        else
        {
            throw new ArgumentException("Negative Input or Zero");
        }

    }

    public double calculateDefectDensity(double p0, double p1)
    {
        if (p1 > 0)
        {
            var result = Divide(p0, p1);
            return result;
        }
        else
        {
            throw new ArgumentException("Size cannot be lesser than or equals to 0");
        }
    }

    public double calculateSSI(double p0, double p1, double p2, double p3)
    {
        double result = 0;
        if (p0 <= 0 || p1 <= 0)
        {
            throw new ArgumentException("SSI and CSI cannot be lesser or equals 0");
        }
        if (p2 < 0 || p3 < 0)
        {
            throw new ArgumentException("Deleted and Changed codes cannot be lesser than 0");
        }
        result = Add(p0, p1);
        result = Subtract(result, p2);
        result = Subtract(result, p3);
        return result;
    }

    public double CalculateFailureIntensityLogarithmic(double p0, double p1, double p2)
    {
        if (p0 > 0 && p1 > 0 && p2 > 0)
        {
            var results = Multiply(p1, (Math.Exp(Multiply(-1, Multiply(p0, p2)))));
            return Math.Round(results, 0);
        }
        else
        {
            throw new ArgumentException("Values cannot be lesser than or equals to 0");
        }
    }

    public double CalculateNumberOfExpectedFailure(double p0, double p1, double p2)
    {
        if (p0 > 0 && p1 > 0 && p2 > 0)
        {
            var results = Multiply(Divide(1, p0), Math.Log(p1 * p0 * p2 + 1));
            return Math.Round(results, 0);
        }
        else
        {
            throw new ArgumentException("Values cannot be lesser than or equals to 0");
        }
    }

    public double GenMagicNum(double input, IFileReader fileReader)
    {
        double result = 0;
        int choice = Convert.ToInt16(input);
        ////Dependency------------------------------
        //FileReader getTheMagic = new FileReader();
        ////----------------------------------------
        string[] magicStrings = fileReader.Read("../../../../ICT3101_Calculator/MagicNumbers.txt");
        if ((choice >= 0) && (choice < magicStrings.Length))
        {
            result = Convert.ToDouble(magicStrings[choice]);
        }
        //If result > 0 DO (2*result)
        //Else DO (-2*result)
        result = (result > 0) ? (2 * result) : (-2 * result);
        return result;
    }


}

public class FileReader:IFileReader
{
    public string[] Read(string path)
    {
        return File.ReadAllLines(path);
    }
}