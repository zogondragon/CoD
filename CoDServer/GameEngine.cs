using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoDServer
{
    public class GameEngine
    {
    }

    // A strategy turn is a month.
    public class StrategyTurn
    {
        
        public string CurrentDate()
        {
            return "AD 1255, Jan.";
        }
    }

    // A battle turn is 1 hour. A battle generally ends in 1~96 hours.
    public class BattleTurn
    {

    }

    // A duel turn is 6 seconds. (1 minute is 10 duel turns).
    public class DuelTurn
    {

    }
}
