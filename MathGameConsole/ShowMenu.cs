using MathGameLibrary;

namespace MathGameConsole
{
    internal class Menu
    {
        public void showMenu(string name,DateTime date)
        {
            DisplayUserName(name,date);
            bool isGameOn = true;
            
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to play today?Choose from the following options.\nV - View Game History\nA - Additon\nM - Multipliaction\nS - Subtraction\nD - Divison\nQ - Quit Game");
                string ans=Console.ReadLine();

                switch (ans.Trim().ToLower())
                {
                    case "a":
                        GameLogic.Addition();
                        break;
                    case "m":
                        GameLogic.Multiplcation();
                        break;
                    case "s":
                        GameLogic.Subtraction();
                        break;
                    case "d":
                        GameLogic.Division();
                        break;
                    case "q":
                        isGameOn = false;
                        break;
                    case "v":
                        Helper.DisplayHistory();
                        break;
                    default:
                        Console.WriteLine("You entered wrong input.Enter again");
                        break;
                }
                    
             }while(isGameOn);
        }

        private void DisplayUserName(string name, DateTime date)
        {
            Console.Clear();

            Console.WriteLine($"Hello {name}.It's {date}.Welcome to Math Game");
            Console.WriteLine("Press any key to show menu.");
            Console.ReadLine();
        }
    }
}