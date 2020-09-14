using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleBattleGenerator.Utils;

namespace ConsoleBattleGenerator.Model
{
    public class Battle
    {
        private BattleUtils battleUtils;
        Random whoStarts = new Random();

        public Battle()
        {
            battleUtils = new BattleUtils();
        }

        public void Start(Warrior warriorA, Warrior warriorB)
        {
            int order = whoStarts.Next(1, 3);
            if (order.Equals(1))
            {
                Console.WriteLine("{0} will start the battle.", warriorA.Name);
                while (true)
                {
                    if (Turn(warriorA, warriorB) == battleUtils.BattleEnd || Turn(warriorB, warriorA) == battleUtils.BattleEnd)
                    {
                        Console.WriteLine(battleUtils.BattleEnd);
                        break;
                    }


                }
            }
            if (order.Equals(2))
            {
                Console.WriteLine("{0} will start the battle.", warriorB.Name);
                Console.WriteLine();
                while (true)
                {


                    if (Turn(warriorB, warriorA) == battleUtils.BattleEnd || Turn(warriorA, warriorB) == battleUtils.BattleEnd)
                    {
                        Console.WriteLine(battleUtils.BattleEnd);
                        break;
                    }


                }
            }


        }

        public string Turn(Warrior attackingWarrior, Warrior defendingWarrior)
        {
            double attackValue = attackingWarrior.Attack();
            int criticalStrike = battleUtils.criticalStrike(attackingWarrior);
            if (attackingWarrior.CriticalStrikeChance != 0 && criticalStrike == 1)
            {
                attackValue *= 2;
            }
            double blockValue = defendingWarrior.Block();
            double damage = attackValue - blockValue;
            if (damage < 0) damage = 0;
            
            defendingWarrior.Health = defendingWarrior.Health - damage;
            if (attackingWarrior.CriticalStrikeChance != 0 && criticalStrike == 1)
            {
                Console.WriteLine("CRITICAL STRIKE!");
            }
            Console.WriteLine("{0} ({5} HP) attacked {1}({6} HP) with {2} power. {3} points of damage were taken ({4} blocked)",
                attackingWarrior.Name, defendingWarrior.Name, attackValue, damage, blockValue, attackingWarrior.Health, defendingWarrior.Health);
            Console.WriteLine();

            if ((defendingWarrior.Health < 30 && defendingWarrior.Health > 0) && defendingWarrior.HasPotions())
            {
                Console.ForegroundColor
                    = ConsoleColor.DarkYellow;
                Console.BackgroundColor
                    = ConsoleColor.DarkMagenta;


                defendingWarrior.Heal();

                Console.ForegroundColor
                    = ConsoleColor.White;
                Console.BackgroundColor
                    = ConsoleColor.Black;
            }
            
            if (defendingWarrior.Health <= 0)
            {
                Console.WriteLine("{0} won the battle.", attackingWarrior.Name);
                return battleUtils.BattleEnd;
            }

            else return null;

        }



    }
}
