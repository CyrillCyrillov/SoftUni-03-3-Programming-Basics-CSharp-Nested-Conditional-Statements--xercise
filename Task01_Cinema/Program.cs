using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string typeOfHall = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double sum = 0;
            // math
            int places = rows * colums;
            // check and ouput
            switch (typeOfHall)
            {
                case "Premiere":
                    {
                        sum = places * 12;
                    }
                    break;
                case "Normal":
                    {
                        sum = places * 7.5;
                    }
                    break;
                case "Discount":
                    {
                        sum = places * 5;
                    }
                    break;
            }
            Console.WriteLine($"{sum:F2} leva");
        }
    }
}
