using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleBattleGenerator.Model;

namespace ConsoleBattleGenerator.Utils
{
    class BattleUtils
    {
        public readonly string BattleEnd = "Duel has ended.";

        Random rnd = new Random();

        public int criticalStrike(Warrior warrior)
        {
            return rnd.Next(1, (100 / warrior.CriticalStrikeChance + 1));
        }
    }
}
