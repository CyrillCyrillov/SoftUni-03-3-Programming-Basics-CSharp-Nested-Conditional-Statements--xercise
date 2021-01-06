using System;

namespace Task03A_New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string kindOfFlower = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;
            // check and ouput
            if (kindOfFlower == "Roses")
            {
                sum = countOfFlowers * 5;
                if (countOfFlowers > 80)
                {
                    sum = sum * 0.9;
                }
            }
            if (kindOfFlower == "Dahlias")
            {
                sum = countOfFlowers * 3.8;
                if (countOfFlowers > 90)
                {
                    sum = sum * 0.85;
                }
            }
            if (kindOfFlower == "Tulips")
            {
                sum = countOfFlowers * 2.8;
                if (countOfFlowers > 80)
                {
                    sum = sum * 0.85;
                }
            }
            if (kindOfFlower == "Narcissus")
            {
                sum = countOfFlowers * 3;
                if (countOfFlowers < 120)
                {
                    sum = sum * 1.15;
                }
            }
            if (kindOfFlower == "Gladiolus")
            {
                sum = countOfFlowers * 2.5;
                if (countOfFlowers < 80)
                {
                    sum = sum * 1.2;
                }
            }
            if (sum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {kindOfFlower} and {(budget - sum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(sum - budget):F2} leva more.");
            }

        }    
    }
}
