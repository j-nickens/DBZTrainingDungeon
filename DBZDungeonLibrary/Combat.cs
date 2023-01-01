using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZDungeonLibrary
{
    //MAKE IT PUBLIC
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            //get a random roll from 1-100
            var roll = new Random().Next(1, 101);
            Thread.Sleep(200);

            //The attacker "hits" if the roll is less than the attacker's hit chance minus defender's block.
            bool success = roll < attacker.CalcHitChance() - defender.CalcBlock();
            if (success)
            {
                //calculate the damage
                int damageDealt = attacker.CalcDamage();

                //assign the damage to the defender
                defender.Life -= damageDealt;
                //output the result
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} landed a stunning blow to {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            #region Potential Expansion - Initiative
        
            //Consider adding an "Initiative" prop to Character
            //Then check the initiative to see who attacks first
            // if (player.Initiative >= monster.Initiative)
            //DoAttack(player, monster)
            // else 
            //DoAttack(monster, player)
            #endregion
        
            DoAttack(player, monster);
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }    
        
    }
}
