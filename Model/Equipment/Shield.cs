using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleGenerator.Model
{
    public class Shield : IItem
    {
        public string Name { get; set; }
        public double Armor { get; set; }

        public Shield(string name, double armor)
        {
            Name = name;
            Armor = armor;
        }

        public void Info()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Armor: {0}", Armor);
            Console.WriteLine();
        }
    }
}
