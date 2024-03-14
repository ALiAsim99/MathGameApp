using MathGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameConsole
{
    public class Program
    {
      public static void Main(string[] args)
        {
            string userName = Helper.GetUserName();
            var date= DateTime.UtcNow;
            Menu menu=new Menu();
            menu.showMenu(userName, date); 

        }

       
    }
}
