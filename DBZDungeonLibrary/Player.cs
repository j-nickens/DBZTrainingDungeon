using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZDungeonLibrary
{
    public class Player : Character
    {

        //Properties - People
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        //Constructors - Collect
        public Player(string name, int hitChance, int block, int maxLife, Race playerRace, Weapon equippedWeapon)
            : base(name, hitChance, block, maxLife)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;
            #region Possible future expansion - player race bonuses

            #endregion
            switch (playerRace)
            {

                case Race.Hybrid:
                    HitChance += 5;
                    Life += 5;
                    Block += 2;
                    break;

            }
        }
        //Methods - Monkeys
        public string GetRaceDesc(Race playerRace)
        {
            return playerRace switch
            {
                Race.Hybrid => "Hybrid",
                
                
            };
        }//end GetRaceDesc()
        public override string ToString()
        {
            return base.ToString() + $"\nWeapon: {EquippedWeapon}\n" +
                $"Description: \n{GetRaceDesc(PlayerRace)}";
        }

        //abstract parent methods MUST be overridden in the child class
        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage + 1);
            return damage;
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
    }
}
