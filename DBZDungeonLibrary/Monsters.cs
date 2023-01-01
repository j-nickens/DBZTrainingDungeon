using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZDungeonLibrary
{
    //make it a public child of Character
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }

        public Monster() { }
        public Monster(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description)
            : base(name, hitChance, block, maxLife)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public override string ToString()
        {
            return $"************** MONSTER **************\n" +
                   $"{base.ToString()}\n" +
                   $"Damage: {MinDamage} to {MaxDamage}\n" +
                   $"Description:\n{Description}";
        }
        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }

        //public static Monster GetMonster()
        //{
            //Create a variety of Monsters
            //Rabbit rabbit = new Rabbit(name: "White Rabbit", maxLife: 25, hitChance: 50,
            //    block: 20, minDamage: 2, maxDamage: 8, description: "That's no ordinary rabbit! Look at the bones!", isFluffy: true);
            //Vampire vampire = new Vampire(name: "Dracula", maxLife: 30, hitChance: 70,
            //    block: 8, minDamage: 1, maxDamage: 8, description: "The father of all the undead");
            //Turtle turtle = new Turtle(name: "Mikey", maxLife: 25, hitChance: 50,
            //    block: 10, minDamage: 1, maxDamage: 4, description: "He is no longer a teenager but he is still /a/ mutant turle", bonusBlock: 3, //hidePercent: 10);
            //Dragon dragon = new Dragon(name: "Smaug", maxLife: 20, hitChance: 65,
            //    block: 20, minDamage: 1, maxDamage: 15, description: "The last great dragon.", isScaly: true);
            //TODO UNCOMMENT AFTER MONSTERS ARE INDIVIDUALLY CREATED

            //var babyTurtle = new Turtle();
            //var babyRabbit = new Rabbit();
            //var babyDragon = new Dragon();
            //TODO UNCOMMENT AFTER MONSTER ARE CREATED INDIVIDUALLY
            //Add the monsters to a collection
            //List<Monster> monsters = new List<Monster>()
            //{
            //    rabbit,
            //    babyRabbit, babyRabbit, babyRabbit,
            //    vampire,
            //    turtle,
            //    babyTurtle, babyTurtle, babyTurtle,
            //    dragon,
            //    babyDragon, babyDragon, babyDragon
            //};

            //Pick one at random to place in the room            
            //int randomNbr = new Random().Next(monsters.Count);
            //Monster monster = monsters[randomNbr];
            //return monster;
    }
}