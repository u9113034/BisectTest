using System;
using UtilityKnife;

namespace LogDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine($"5+3 = {calculator.Add(5, 3)}");
            Console.WriteLine($"5/3 = {calculator.Division(5 / 3)}");
        }
    }
}