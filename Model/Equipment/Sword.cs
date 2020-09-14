using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleGenerator.Model.Equipment
{
    public class Sword : IItem
    {
        public string Name { get; set; }
        public double Attack { get; set; }

        public Sword(string name, double attack)
        {
            Name = name;
            Attack = attack;
        }

        public void Info()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Attack: {0}", Attack);
            Console.WriteLine();
        }
    }
}
