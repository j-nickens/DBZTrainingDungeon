using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZDungeonLibrary
{
    public class GokuBlack : Monster
    {
        public bool IsSSR { get; set; }

        public GokuBlack(string name, int maxLife, int hitChance, int block, int minDamage,
           int maxDamage, string description, bool isSSR)
           : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsSSR = isSSR;
        }
        public GokuBlack()
        {
            MaxLife = 5;
            MaxDamage = 3;
            Name = "Goku Wack";
            Life = 5;
            HitChance = 25;
            Block = 12;
            MinDamage = 1;
            Description = "An earthling dressed as goku black!...";
            IsSSR = false;
        }
        public override string ToString()
        {
            return base.ToString() + (IsSSR ? " Glowing pink with a strange aura!" : " His wig isn't even staying on....");
        }

        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;

            if (IsSSR)
            {
                calculatedDamage += calculatedDamage / 2;
            }

            return calculatedDamage;
        }
    }
}
