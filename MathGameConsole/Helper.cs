using MathGameConsole.Models;
using static MathGameConsole.Models.ENUM;

namespace MathGameLibrary
{
    internal class Helper
    {   
        static List<GameModel> gameHistory= new List<GameModel>();
        internal static int[] GenerateRandomDivisonNumber()
        {
            Random rand = new Random();
            int first=rand.Next(1,99);
            int second=rand.Next(1,99);

            while (first % second != 0)
            {
                first = rand.Next(1, 99);
                    second = rand.Next(1, 99); 
            }
            return [first, second];
        }

        internal static int GenerateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 9);

        }
        internal static void AddGameHistory(int score,GameType type)
        {   
            gameHistory.Add(new GameModel {date=DateTime.UtcNow,Score=score,Type=type});

        }
        internal static int GetAnswer()
        {
            string readInput=Console.ReadLine();
            int ans = 0;
            while(!int.TryParse(readInput, out ans))
            {
                Console.WriteLine("Answer needs to be a valid number.Try again");
                readInput=Console.ReadLine();
            }
            return ans;
        }

        internal static string GetUserName()
        {
            Console.Write("Enter your name:");
            string ans = Console.ReadLine();
            while (string.IsNullOrEmpty(ans))
            {

                Console.WriteLine("Name cant be empty.Enter name again;");
                ans = Console.ReadLine();
            }
            return ans;
        }

        internal static void DisplayHistory()
        {
            Console.Clear();
            Console.WriteLine("---------------");
            foreach (var game in gameHistory)
            {
                Console.WriteLine($"{game.Type} - {game.Score} - {game.date}");
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Press any key to go back to menu");
            Console.ReadLine();
        }
    }
}