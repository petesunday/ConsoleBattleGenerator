using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleBattleGenerator.Model;
using ConsoleBattleGenerator.Model.Equipment;

namespace ConsoleBattleGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warriorOne = new Warrior("Jack", 150, 25, 15, 50);
            Warrior warriorTwo = new Warrior("Chad", 150, 30, 20, 20);

            Potion potion = new Potion("Medicine", 40, 3);
            Potion potion2 = new Potion("Medicine", 40, 3);
            Sword sword = new Sword("Rozcinacz na kwadry", 20);
            Shield shield = new Shield("GIMP Logo Shield", 30);

            warriorOne.AddPotionToEquipment(potion);
            warriorTwo.AddPotionToEquipment(potion2);

            warriorOne.AddSwordToEquipment(sword);
            warriorTwo.AddShieldToEquipment(shield);

            Battle battle = new Battle();
            battle.Start(warriorOne, warriorTwo);
            


            Console.ReadLine();
        }
    }
}
