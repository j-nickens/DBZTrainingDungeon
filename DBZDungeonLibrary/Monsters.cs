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

        public static Monster GetMonster()
        {
            //Create a variety of Monsters
            GokuBlack gokuBLack = new GokuBlack(name: "Goku Black", maxLife: 25, hitChance: 60,
                block: 20, minDamage: 2, maxDamage: 8, description: "That's not Goku his energy feels evil...!", isSSR: true);
            
            Jiren jiren = new Jiren(name: "Jiren", maxLife: 30, hitChance: 70,
                block: 8, minDamage: 1, maxDamage: 9, description: "The hero of Universe 11!", isEnraged: true);
           
            Cooler cooler = new Cooler(name: "Cooler", maxLife: 25, hitChance: 55,
                block: 10, minDamage: 1, maxDamage: 4, description: "The Brother of Lord Frieza", isPerfectCooler: true);
            
            Frieza frieza = new Frieza(name: "Frieza", maxLife: 20, hitChance: 65,
                block: 20, minDamage: 1, maxDamage: 15, description: "The Destroyer of planets Lord Frieza", isFinalForm: true);
            
            MajiinBuu buu = new MajiinBuu(name: "Majiin Buu", maxLife: 25, hitChance: 68,
                block: 20, minDamage: 1, maxDamage: 9, description: "Awakened by Bibidi, he is here to destroy everyone.", isKidBuu: true);
            
            Cell cell = new Cell(name: "Cell", maxLife: 20, hitChance: 60,
                block: 15, minDamage: 1, maxDamage: 8, description: "Composed of cells from Piccolo, Vegeta, Frieza, and King Cold.", isPerfectCell: true);


            //TODO UNCOMMENT AFTER MONSTERS ARE INDIVIDUALLY CREATED

            var babyJiren = new Jiren();
            var cellJr = new Cell();
            var buuJr = new MajiinBuu();
            var coolerJr = new Cooler();
            var gokuWack = new GokuBlack();
            var miniFrieza = new Frieza();
            //Add the monsters to a collection
            List<Monster> monsters = new List<Monster>()
            {
                gokuBLack,
                buuJr, babyJiren, coolerJr,
                cell,
                babyJiren, miniFrieza, buuJr,
                jiren,
                miniFrieza, cellJr, coolerJr,
                frieza,
                miniFrieza, cellJr, coolerJr,
                buu,
                buuJr,babyJiren, coolerJr,
                cooler

            };

            //Pick one at random to place in the room            
            int randomNbr = new Random().Next(monsters.Count);
            Monster monster = monsters[randomNbr];
            return monster;
        }
    }
}