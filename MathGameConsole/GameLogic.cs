using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathGameConsole.Models.ENUM;
using static System.Formats.Asn1.AsnWriter;

namespace MathGameLibrary
{
    public static class GameLogic
    {
        internal static void Addition()
        {
            int score = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Addition Game");

                double a = Helper.GenerateRandomNumber();
                int b = Helper.GenerateRandomNumber();
                Console.WriteLine($"{a}+{b}");
                int ans = Helper.GetAnswer();
                if (ans == (a + b))
                {
                    Console.WriteLine("You entered the right answer!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Sorry you entered the wrong answer!");
                }
                Console.ReadLine();

            }
            Console.WriteLine($"Game finished.Your final game score is {score}");
            Helper.AddGameHistory(score, GameType.Addition);
        }

        public static void Division()
        {
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Divison Game");
                int[] numbers = Helper.GenerateRandomDivisonNumber();
                int a = numbers[0];
                int b = numbers[1];
                Console.WriteLine($"{a}/{b}");
                int ans = Helper.GetAnswer();
                if (ans == (a / b))
                {
                    Console.WriteLine("You entered the right answer!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Sorry you entered the wrong answer!");
                }
                Console.ReadLine();

            }
            Console.WriteLine($"Game finished.Your final game score is {score}");

            Helper.AddGameHistory(score, GameType.Division);

        }

        public static void Multiplcation()
        {
           
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Multiplication Game");
                double a = Helper.GenerateRandomNumber();
                int b = Helper.GenerateRandomNumber();
                Console.WriteLine($"{a}+{b}");
                int ans = Helper.GetAnswer();
                if (ans == (a * b))
                {
                    score++;
                    Console.WriteLine("You entered the right answer!");
                }
                else
                {
                    Console.WriteLine("Sorry you entered the wrong answer!");
                }
                Console.ReadLine();

            }
            Console.WriteLine($"Game finished.Your final game score is {score}");

            Helper.AddGameHistory(score, GameType.Multiplication);

        }

        public static void Subtraction()
        {
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Subtraction Game");
                double a = Helper.GenerateRandomNumber();
                int b = Helper.GenerateRandomNumber();
                Console.WriteLine($"{a}+{b}");
                int ans = Helper.GetAnswer();
                if (ans == (a - b))
                {
                    Console.WriteLine("You entered the right answer!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Sorry you entered the wrong answer!");
                }
                Console.ReadLine();

            }
            Console.WriteLine($"Game finished.Your final game score is {score}");

            Helper.AddGameHistory(score, GameType.Subtraction);

        }
    }
}
