using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZDungeonLibrary
{
    public class Jiren : Monster
    {
        public bool IsEnraged { get; set; }

        public Jiren(string name, int maxLife, int hitChance, int block, int minDamage,
           int maxDamage, string description, bool isEnraged)
           : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsEnraged = isEnraged;
        }
        public Jiren()
        {
            MaxLife = 5;
            MaxDamage = 3;
            Name = "Baby Jiren";
            Life = 5;
            HitChance = 20;
            Block = 15;
            MinDamage = 1;
            Description = "A baby jiren, his head is so big!...";
            IsEnraged = false;
        }
        public override string ToString()
        {
            return base.ToString() + (IsEnraged ? "Glowing red with rage!" : "His head is just so big....");
        }

        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;

            if (IsEnraged)
            {
                calculatedDamage += calculatedDamage / 2;
            }

            return calculatedDamage;
        }
    }
}
