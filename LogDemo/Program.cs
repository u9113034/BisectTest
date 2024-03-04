using System;
using UtilityKnife

namespace LogDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine($"5+3 = {calculator.Add(5, 3)}");
            Console.WriteLine($"The square root of 3.14159 is {calculator.SquareRoot(3.14159)}");
        }
    }
}