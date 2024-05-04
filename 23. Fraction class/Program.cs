using System.Text;
using System;

public class Fraction
{
    public (double[], double[]) GetFracArray(string numerator, string denominator)
    {
        string n;
        Console.WriteLine("Hãy nhập vào số lượng phân số của bạn: ");
        n = Console.ReadLine();
        int intN;
        while (!int.TryParse(n, out intN)) 
        {
            Console.WriteLine("Số lượng phân số đã bị lỗi: ");
            Console.WriteLine("Hãy nhập vào số lượng phân số của bạn: ");
            n = Console.ReadLine();
        }
        
        double[] numeratorInput = new double[intN];
        double[] denominatorInput = new double[intN];
        for (int i = 0; i < intN; i++)
        {

            Console.WriteLine($"Hãy nhập vào tử số thứ {i + 1}: ");
            numerator = Console.ReadLine();
            double doubleNumerator;
            while (!double.TryParse(numerator, out doubleNumerator))
            {
                Console.WriteLine("Tử số đã bị lỗi, vui lòng nhập lại tử số: ");
                Console.WriteLine($"Hãy nhập vào tử số thứ {i + 1}: ");
                numerator = Console.ReadLine();
            }
            numeratorInput[i] = doubleNumerator;
            Console.WriteLine($"Hãy nhập vào mẫu số thứ {i + 1}: ");
            denominator = Console.ReadLine();
            double doubleDenominator;
            while (!double.TryParse(denominator, out doubleDenominator) || !IsValidDenominator(doubleDenominator))
            {
                Console.WriteLine("Mẫu số đã bị lỗi, vui lòng nhập lại mẫu số: ");
                Console.WriteLine($"Hãy nhập vào mẫu số thứ {i + 1}: ");
                denominator = Console.ReadLine();    
            }
            denominatorInput[i] = doubleDenominator;
        }
        
        return (numeratorInput, denominatorInput);
    }
    public bool IsValidDenominator(double denominator)
    {
        if (denominator == 0)
            return false;
        else
            return true;
    }
    public double[] FractionsConvert(double[] numerator, double[] denominator)
    {
        double[] fractions = new double[denominator.Length];
        for (int i = 0; i < denominator.Length; i++)
        {
            fractions[i] = (double)numerator[i] / denominator[i];
        }
        return fractions;
    }
    public double AverageSum(double[] fractions)
    {
        double sum = 0;
        foreach (double fraction in fractions)
        {
            sum += fraction;
        }
        double average = sum / fractions.Length;
        return average;
    }
    public void PrintScreen(double average)
    {
        Console.WriteLine($"Trung bình cộng của các phân số được nhập vào là: {average}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Fraction fraction = new Fraction();
        string numerator = "";
        string denominator = "";
        (double[] fracnumerator, double[] fracdenominator) = fraction.GetFracArray(numerator, denominator);
        double[] fracArray = fraction.FractionsConvert(fracnumerator, fracdenominator);
        double average = fraction.AverageSum(fracArray);
        fraction.PrintScreen(average);
    }
}