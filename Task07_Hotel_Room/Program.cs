using System;

namespace Task07_Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string mount = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double sumStudio = 0;
            double sumApartment = 0;

            // check and output
            if (mount == "May" || mount == "October")
            {
                sumStudio = 50 * nights;
                sumApartment = 65 * nights;
                if (nights > 7 && nights <= 14)
                {
                    sumStudio = sumStudio * 0.95;
                }
                else if (nights > 14)
                {
                    sumStudio = sumStudio * 0.7;
                }
            }
            else if (mount == "June" || mount == "September")
            {
                sumStudio = 75.2 * nights;
                sumApartment = 68.7 * nights;
                if (nights > 14)
                {
                    sumStudio = sumStudio * 0.8;
                }
            }
            else if (mount == "July" || mount == "August")
            {
                sumStudio = 76 * nights;
                sumApartment = 77 * nights;
            }
            if (nights > 14)
            {
                sumApartment = sumApartment * 0.9;
            }
            Console.WriteLine($"Apartment: {sumApartment:F2} lv.");
            Console.WriteLine($"Studio: {sumStudio:F2} lv.");
        }
    }
}
