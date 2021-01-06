using System;

namespace Task05_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double budget = double.Parse(Console.ReadLine());
            string seаson = Console.ReadLine();
            // check and output
            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (seаson == "summer")
                {
                    Console.WriteLine($"Camp - {(budget * 0.3):F2}");
                }
                else if (seаson == "winter")
                {
                    Console.WriteLine($"Hotel - {(budget * 0.7):F2}");
                }
            }
            else if (101 <= budget && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (seаson == "summer")
                {
                    Console.WriteLine($"Camp - {(budget * 0.4):F2}");
                }
                else if (seаson == "winter")
                {
                    Console.WriteLine($"Hotel - {(budget * 0.8):F2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {(budget * 0.9):F2}");
            }
        }
    }
}
