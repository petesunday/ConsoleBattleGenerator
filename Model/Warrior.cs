using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleBattleGenerator.Model.Equipment;

namespace ConsoleBattleGenerator.Model
{
    public class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackValue { get; set; }
        public double ArmorValue { get; set; }
        public int CriticalStrikeChance { get; set; }

        public Dictionary<String, IItem> equipment;

        public Random randomValue = new Random();

        public Warrior(string name = "Warrior", double health = 100, double attack = 10, double armor = 10, int criticalStrikeChance = 0)
        {
            Name = name;
            Health = health;
            AttackValue = attack;
            ArmorValue = armor;
            CriticalStrikeChance = criticalStrikeChance;
            equipment = new Dictionary<string, IItem>()
            {
                {"Sword", null},
                {"Shield", null},
                {"Potion", null}

            };
        }

        public double Attack()
        {
            return randomValue.Next(1, (int)AttackValue);
        }

        public double Block()
        {
            return randomValue.Next(1, (int)ArmorValue);
        }

        public void AddPotionToEquipment(Potion potion)
        {
            equipment["Potion"] = potion;
        }

        public void AddSwordToEquipment(Sword sword)
        {
            equipment["Sword"] = sword;
            AttackValue += sword.Attack;
        }

        public void AddShieldToEquipment(Shield shield)
        {
            equipment["Shield"] = shield;
            ArmorValue += shield.Armor;
        }

        public bool HasPotions()
        {
            Potion potion = (Potion)equipment["Potion"];
            if (potion != null && potion.Amount > 0)
                return true;
            
            return false;
        }

        public void Heal()
        {
            Potion potion = (Potion)equipment["Potion"];
            Health += potion.HealthRegen;
            potion.Amount--;
            Console.WriteLine("{0} used potion and heal for {1} points.", Name, potion.HealthRegen);
            Console.WriteLine("Current HP: {0}, potions left: {1}", Health, potion.Amount);
            Console.WriteLine();
        }


    }
}
