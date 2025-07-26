using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_demo_cs
{
    class Program
    {
        // METHOD OVERLOADING DEMO
        // Method overloading allows multiple methods to have the same name
        // but with different parameter types or number of parameters.
        // Signature = Method Name + Parameter Types (not return type)

        static void Main(string[] args)
        {
            // Using overloaded Multiply methods

            // Two double parameters
            double total1 = Multiply(2.5, 3.5);
            // Two int parameters
            double total2 = Multiply(2, 3);
            // One double parameter
            double total3 = Multiply(5.0);

            Console.WriteLine($"Multiply(2.5, 3.5) = {total1}");
            Console.WriteLine($"Multiply(2, 3) = {total2}");
            Console.WriteLine($"Multiply(5.0) = {total3}");
        }

        static double Multiply(double valueA, double valueB)
        {
            return valueA * valueB;
        }

        static double Multiply(int valueA, int valueB)
        {
            return valueA * valueB;
        }

        static double Multiply(double value)
        {
            return value * value;
        }
    }
}
