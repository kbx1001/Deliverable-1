using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //assign three numbers
            double firstNumber, secondNumber, thirdNumber;

            Console.WriteLine("Please enter in your first number.");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter in your second number.");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter in your third number.");
            thirdNumber = Convert.ToDouble(Console.ReadLine());

            double total = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine("Your total is: " + total);
            Console.WriteLine("The average of the three: " + total / 3);
            Console.WriteLine("Largest of the three: " + Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber)));
            Console.WriteLine("Lowest of the three: " + Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber)));

            //Currency: USD, THB, JPY, SEK

            double us = total * 1;
            double swedish = total * 9.68;
            double japan = total * 107.54;
            double thai = total * 30.61;

            Console.WriteLine("US: " + us.ToString("C", CultureInfo.CreateSpecificCulture("us-US")));
            Console.WriteLine("Swedish: " + swedish.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Japanese: " + japan.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai: " + thai.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));

        }
    }
}
