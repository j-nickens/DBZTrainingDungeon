using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZDungeonLibrary
{
    public class Cell : Monster
    {
        public bool PerfectCell { get; set; }
        public Cell(string name, int maxLife, int hitChance, int block, int minDamage,
           int maxDamage, string description, bool isPerfectCell)
           : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            PerfectCell = PerfectCell;
        }
        public Cell()
        {
            MaxLife = 8;
            MaxDamage = 3;
            Name = "Cell Jr";
            Life = 8;
            HitChance = 25;
            Block = 10;
            MinDamage = 1;
            Description = "IT's CELL JR WATCH OUT!!...";
            PerfectCell = false;
        }
        public override string ToString()
        {
            return base.ToString() + (PerfectCell ? " THIS IS HIS PERFECT FORM....!!" : " His power level isn't very high he must not have absorbed anyone yet..");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (PerfectCell)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
