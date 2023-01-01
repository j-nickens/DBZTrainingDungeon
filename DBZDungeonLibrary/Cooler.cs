using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZDungeonLibrary
{
    public class Cooler : Monster
    {
        public bool IsPerfectCooler { get; set; }
        public Cooler(string name, int maxLife, int hitChance, int block, int minDamage,
           int maxDamage, string description, bool isPerfectCooler)
           : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsPerfectCooler = isPerfectCooler;
        }
        public Cooler()
        {
            MaxLife = 5;
            MaxDamage = 2;
            Name = "Cooler Jr";
            Life = 5;
            HitChance = 13;
            Block = 10;
            MinDamage = 1;
            Description = "It is a miniature version of Cooler...";
            IsPerfectCooler = false;
        }
        public override string ToString()
        {
            return base.ToString() + (IsPerfectCooler ? "This is the final form!" : "Little Cutie!");
        }

        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;

            if (IsPerfectCooler)
            {
                calculatedDamage += calculatedDamage / 2;
            }

            return calculatedDamage;
        }
    }
}
