using System;

namespace Task08_On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int hourExamen = int.Parse(Console.ReadLine());
            int minuteExamen = int.Parse(Console.ReadLine());
            int hourCome = int.Parse(Console.ReadLine());
            int minuteCome = int.Parse(Console.ReadLine());
            int generalExamen = 60 * hourExamen + minuteExamen;
            int generalCome = 60 * hourCome + minuteCome;
            int difference = 0;


            // check and output
            if (generalCome > generalExamen)
            {
                Console.WriteLine("Late");
                difference = generalCome - generalExamen;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else if (difference >= 60)
                        if (difference % 60 == 0)
                        {
                        Console.WriteLine($"{difference / 60}:00 hours after the start");
                        }
                        else 
                        {
                            Console.WriteLine($"{difference / 60}:{difference % 60} hours after the start");
                        }
            }
            else if (generalExamen == generalCome)
            {
                Console.WriteLine("On time");
            }
            else if (generalExamen - generalCome <= 30)
            {
                Console.WriteLine("On time");
                difference = generalExamen - generalCome;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference >= 60)
                    if (difference % 60 == 0)
                    {
                        Console.WriteLine($"{difference / 60}:00 hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{difference / 60}:{difference % 60} hours before the start");
                    }
            }
            else if (generalExamen - generalCome > 30)
            {
                Console.WriteLine("Early");
                difference = generalExamen - generalCome;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference >= 60)
                    if (difference % 60 == 0)
                    {
                        Console.WriteLine($"{difference / 60}:00 hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{difference / 60}:{difference % 60} hours before the start");
                    }
            }
            
        }
    }
}
