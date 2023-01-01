using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBZDungeonLibrary
{
    public class Frieza : Monster
    {
        public bool IsFinalForm { get; set; }

        public Frieza(string name, int maxLife, int hitChance, int block, int minDamage,
           int maxDamage, string description, bool isFinalForm)
           : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsFinalForm = isFinalForm;
        }
        public Frieza()
        {
            MaxLife = 7;
            MaxDamage = 4;
            Name = "Mini-Frieza";
            Life = 7;
            HitChance = 25;
            Block = 19;
            MinDamage = 1;
            Description = "Aww cute little Frieza! Whoa his power level is pretty high still!...";
            IsFinalForm = false;
        }
        public override string ToString()
        {
            return base.ToString() + (IsFinalForm ? "This must be his final form..." : "It's Frieza!!!! ");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsFinalForm)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
