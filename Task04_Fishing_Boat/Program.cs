using System;

namespace Task04_Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermеn = int.Parse(Console.ReadLine());
            double sum = 0;
            // check and output
            switch (season)
            {
                case "Spring":
                    {
                        sum = 3000;
                        if (numberOfFishermеn <= 6)
                        {
                            sum = sum * 0.9;
                        }
                        else if (7 <= numberOfFishermеn && numberOfFishermеn <= 11)
                        {
                            sum = sum * 0.85;
                        }
                        else if (numberOfFishermеn >= 12)
                        {
                            sum = sum * 0.75;
                        }
                    }
                    break;
                case "Summer":
                case "Autumn":
                    {
                        sum = 4200;
                        if (numberOfFishermеn <= 6)
                        {
                            sum = sum * 0.9;
                        }
                        else if (7 <= numberOfFishermеn && numberOfFishermеn <= 11)
                        {
                            sum = sum * 0.85;
                        }
                        else if (numberOfFishermеn >= 12)
                        {
                            sum = sum * 0.75;
                        }
                    }
                    break;
                case "Winter":
                    {
                        sum = 2600;
                        if (numberOfFishermеn <= 6)
                        {
                            sum = sum * 0.9;
                        }
                        else if (7 <= numberOfFishermеn && numberOfFishermеn <= 11)
                        {
                            sum = sum * 0.85;
                        }
                        else if (numberOfFishermеn >= 12)
                        {
                            sum = sum * 0.75;
                        }
                    }
                    break;               
            }
            if (season != "Autumn" && (numberOfFishermеn % 2) == 0)
            {
                sum = sum * 0.95;
            }
            if (budget > sum)
            {
                Console.WriteLine($"Yes! You have {(budget - sum):F2} leva left.");
            }
            else if (budget < sum)
            {
                Console.WriteLine($"Not enough money! You need {(sum - budget):F2} leva.");
            }
        }
    }
}
