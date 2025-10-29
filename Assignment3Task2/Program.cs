using System;

namespace Assignment3Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Calculator Demo:\n");

            Calculator add = new Calculator(10, 5, '+');
            Console.WriteLine($"10 + 5 = {add.Calculate()}");

            Calculator sub = new Calculator(10, 5, '-');
            Console.WriteLine($"10 - 5 = {sub.Calculate()}");

            Calculator mul = new Calculator(10, 5, '*');
            Console.WriteLine($"10 * 5 = {mul.Calculate()}");

            Calculator div = new Calculator(10, 5, '/');
            Console.WriteLine($"10 / 5 = {div.Calculate()}");
        }
    }
}