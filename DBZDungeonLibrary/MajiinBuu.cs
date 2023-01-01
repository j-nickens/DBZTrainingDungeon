using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZDungeonLibrary
{
    public class MajiinBuu : Monster
    {
        public bool IsKidBuu { get; set; }

        public MajiinBuu(string name, int maxLife, int hitChance, int block, int minDamage,
           int maxDamage, string description, bool isKidBuu)
           : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsKidBuu = isKidBuu;
        }
        public MajiinBuu()
        {
            MaxLife = 7;
            MaxDamage = 3;
            Name = "Buu Jr";
            Life = 7;
            HitChance = 25;
            Block = 15;
            MinDamage = 1;
            Description = "I am not sure what this thing is! ";
            IsKidBuu = false;
        }
        public override string ToString()
        {
            return base.ToString() + (IsKidBuu ? "HIS POWER LEVEL IS OVER 3000!! " : "This should be easy he is no where near ast strong ");
        }

        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;

            if (IsKidBuu)
            {
                calculatedDamage += calculatedDamage / 2;
            }

            return calculatedDamage;
        }
    }
}
