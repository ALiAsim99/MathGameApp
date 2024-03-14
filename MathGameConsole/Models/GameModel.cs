using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathGameConsole.Models.ENUM;

namespace MathGameConsole.Models
{
    public class GameModel
    {
        public string UserName { get; set; }
        public  GameType Type{ get; set; }

        public  DateTime date  { get; set; }

        public int Score { get; set; }
    }
}
