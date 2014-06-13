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
    // Immutable.
    public class StrategyTurn
    {
        public readonly int Turn;

        public StrategyTurn(Date date)
        {
            // AD 1255, Jan. is 0 turn - strategy turns start at 0.
            Turn = ((date.Year - 1255) * 12) + (date.Month - 1);
        }

        public string CurrentDate()
        {
            // TODO: Generalize this.
            return "AD 1255, Jan.";
        }
    }

    // Represent a historical date (resolution is month)
    // Immutable.
    public class Date
    {
        public readonly int Year;
        public readonly int Month;

        public Date(int year)
        {
            if (year < 1255 || year > 1468) throw new ArgumentOutOfRangeException("year");

            // if no month is provided, then assume January
            Year = year;
            Month = 1;
        }

        public Date(int year, int month)
        {
            if (year < 1255 || year > 1468) throw new ArgumentOutOfRangeException("year");
            // CoD does not care about leap month and leap year
            if (month < 1 || month > 12) throw new ArgumentOutOfRangeException("month");

            Year = year;
            Month = month;
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
