using System;
using System.Collections;
using System.Linq;

namespace Fun_Recommmendations
{
    class Program
    {
        public static string YourMood(int answer1)
        {
            while (answer1 <= 4 && answer1 >= 0)

                if (answer1 == 1)
                {
                    return Convert.ToString("Action");
                }
                else if (answer1 == 2)
                {
                    return Convert.ToString("Chilling");
                }
                else if (answer1 == 3)
                {
                    return Convert.ToString("Danger");
                }
                else if (answer1 == 4)
                {
                    return Convert.ToString("Good Food");
                }
            return Convert.ToString("please enter a number between 1 and 4");

        }
        public static string YourActivities(int answer1)
        {
            while (answer1 <= 4 && answer1 >= 0)

                if (answer1 == 1)
                {
                    return Convert.ToString("stock car racing");
                }
                else if (answer1 == 2)
                {
                    return Convert.ToString("hiking");
                }
                else if (answer1 == 3)
                {
                    return Convert.ToString("skydiving");
                }
                else if (answer1 == 4)
                {
                    return Convert.ToString("to taco bell");
                }
            return Convert.ToString("please enter a number between 1 and 4");

        }
        public static string YourRide(int answer2)
        {
            while (answer2 >= 0)

                if (answer2 == 0)
                {
                    return Convert.ToString("Sneakers");
                }
                else if (answer2 >= 1 || answer2 <= 4)
                {
                    return Convert.ToString("a sedan");
                }
                else if (answer2 >= 5 || answer2 <= 10)
                {
                    return Convert.ToString("a Volkswagen bus");
                }
                else if (answer2 >= 10)
                {
                    return Convert.ToString("an airplane");
                }
            return Convert.ToString("please enter a number between 1 and 4");
        }

        static void Main()
        {
            int answer1, answer2;

            Console.WriteLine("Hello user! What Are you in the mood for?\n");
            Console.WriteLine("Here are you Options:\n");
            Console.WriteLine("1) Action \n2) Chilling \n3) Danger \n4) Good Food");

            answer1 = Convert.ToInt32(Console.ReadLine());

            while (answer1 <= 1 || answer1 >= 4)

                if (answer1 == 1 || answer1 == 2 || answer1 == 3 || answer1 == 4)
                {
                    Console.WriteLine("How many people are you bringing?");
                    break;
                }
                else if (answer1 != 1)
                {
                    Console.WriteLine("Please Enter a number between 1 and 4");
                    answer1 = Convert.ToInt32(Console.ReadLine());
                }

            answer2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Okay if your in the mood for " + Convert.ToString(YourMood(answer1)) + ", then you should go " + Convert.ToString(YourActivities(answer1)) + " and travel in " + Convert.ToString(YourRide(answer2)) + ".\n");

            Console.WriteLine();

            Console.WriteLine("Enjoy your day, Goodbye!");

            Console.ReadLine();

        }

    }
}

