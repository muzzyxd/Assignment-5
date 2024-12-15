using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1__Method_Overloading_
{
    class Calculator
    {
        public int Add(int a , int b)
        {
            return a + b;
        }
        public double Add(double a , double b)
        {
            return a + b;
        }
        public string Add(string a, string b)
        { 
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int intResult = calculator.Add(50, 20);
            Console.WriteLine($"Sum of integers:{intResult}");

            double doubleResult = calculator.Add(10.4,90.0);
            Console.WriteLine($"Sum of double:{doubleResult}");

            string stringResult = calculator.Add("My Name is ","Muzammil.");
            Console.WriteLine($"Concatenated strings:{stringResult}");

            Console.ReadLine();
        }
    }
}
