using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZDungeonLibrary
{
    public class Weapon
    {

        //Fields - Funny
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;//Block 3 - Added Weapon Type field

        //Properties - People
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int BonusHitChance { get { return _bonusHitChance; } set { _bonusHitChance = value; } }
        public bool IsTwoHanded { get { return _isTwoHanded; } set { _isTwoHanded = value; } }

        //Block 3 - Added Weapon Type prop
        public WeaponType Type { get { return _type; } set { _type = value; } }
        public int MinDamage
        {

            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }

        //Constructors - Collect
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            //ANY properties with business rules based off of OTHER properties MUST
            //come AFTER those other properties are set. MinDamage depends on MaxDamage, so max damage
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }
        //Methods - Monkeys
        public override string ToString()
        {
            //Add type to the ToString()
            //return base.ToString();
            return $"{Name}\t{MinDamage} to {MaxDamage} Damage\n" +
                $"Bonus Hit: {BonusHitChance}%\n";
        }
    }
}
