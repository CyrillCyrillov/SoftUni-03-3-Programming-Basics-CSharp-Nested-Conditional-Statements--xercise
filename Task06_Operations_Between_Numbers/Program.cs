using System;

namespace Task06_Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            string evenOrOdd = "odd";

            // check and output
            if (n2 == 0 && (operation == "/" || operation == "%"))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (operation == "+")
            {
               if ((n1+n2)%2 == 0)
               {
                    evenOrOdd = "even";
               }
               Console.WriteLine($"{n1} {operation} {n2} = {n1 + n2} - {evenOrOdd}");
            }
            else if (operation == "-")
            {
                if ((n1 - n2) % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                Console.WriteLine($"{n1} {operation} {n2} = {n1 - n2} - {evenOrOdd}");
            }
            else if (operation == "*")
            {
                if ((n1 * n2) % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                Console.WriteLine($"{n1} {operation} {n2} = {n1 * n2} - {evenOrOdd}");
            }
            else if (operation == "/")
            {
                Console.WriteLine($"{n1} {operation} {n2} = {(n1 / n2):F2}");
            }
            else if (operation == "%")
            {
                Console.WriteLine($"{n1} {operation} {n2} = {n1 % n2}");
            }
        }
    }
}
