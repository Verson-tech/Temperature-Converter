using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
        public static void FahrenheitToCelcius()
        {
            Console.WriteLine("Enter the temperature in Fahrenheit to be converted to Celcius:");
            double tempInputF = Int32.Parse(Console.ReadLine());
            double tempOutputC = (tempInputF - 32) * 5 / 9;
            Console.WriteLine($"{tempInputF} Fahrenheit equals {tempOutputC} Celcius.");
        }
        public static void CelciusToFahrenheit()
        {
            Console.WriteLine("Enter the temperature in Celcius to be converted to Fahrenheit:");
            double tempInputC = Int32.Parse(Console.ReadLine());
            double tempOutputF = (tempInputC * 9/5) + 32;
            Console.WriteLine($"{tempInputC} Celcius equals {tempOutputF} Fahrenheit.");
        }
    }
}
