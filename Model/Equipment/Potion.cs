using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleGenerator.Model.Equipment
{
    public class Potion : IItem
    {
        public string Name { get; set; }
        public double HealthRegen { get; set; }

        public int Amount { get; set; }

        public Potion(string name, double healthRegen, int amount)
        {
            Name = name;
            HealthRegen = healthRegen;
            Amount = amount;
        }

        public void Info()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Health Regen: {0}", HealthRegen);
            Console.WriteLine("Amount: {0}", Amount);
            Console.WriteLine();
        }
    }
}
