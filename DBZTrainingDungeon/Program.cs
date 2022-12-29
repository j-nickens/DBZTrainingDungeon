
namespace DBZTrainingDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title / Introduction
            Console.Title = "Capsule Corp Training Dungeon";
            Console.WriteLine("Your journey begins...\n");
            #endregion

            #region Player Creation

            #region Character Creator
            //Let them choose their name

            //Show them a list of precreated Weapons (Weapon.PickWeapon())

            //Enum.GetValues<RAce>().ToList() -- see ClassicMonsters example in Enums.Cs

            //Could also show  list of pre created players
            #endregion

            int score = 0;//player score
            
            

            //Weapon w1 = new Weapon(1, 8, "Long Sword", 10, true);
            //Console.WriteLine(w1);UNCOMMENT AFTER WEAPON IS CREATED

            //Player player = new Player("Leeroy Jenkins", 70, 5, 40, Race.Human, w1);//UNCOMMENT AFTER CHARACTER CLASS IS CREATED
            #endregion


            #region Main Game Loop
            bool quit = false;
            do
            {

                Console.WriteLine(GetRoom());
                #region potential expansion
                //could crate a room datatype class
                //Description, monsters to those specific rooms,
                //ID
                #endregion




                //Monster monster = Monster.GetMonster();//Uncomment after creating monetser library 
                //Console.WriteLine("In this room: " + monster.Name);//UNCOMMENT after monsters are created
                //inner loop:
                #region Gameplay Menu Loop
                bool reload = false;
                do
                {
                    #region Menu
                    Console.WriteLine("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    string menuChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    //menu switch
                    switch (menuChoice)
                    {
                        case "A":

                            #region possible expansion - racial/ weapon bonus attack
                            //if (player.PlayerRace == Race.Elf)
                            //{ Combat.DoAttack(player, monster) }
                            #endregion
                            //Combat.DoBattle(player, monster);//Uncomment after Battle is created
                            //check if monster is dead
                           //if (monster.Life <= 0)
                           //{
                           //    //use green text to hightlight winning combat
                           //    Console.ForegroundColor = ConsoleColor.Green;
                           //    //Console.WriteLine($"\nYou killed {monster.Name}!");UNCOMMENT AFTER MONSTERS ARE CREATED
                           //    Console.ResetColor();
                           //    score++;
                           //    #region Loot Drops
                           //    //NOTE: This would require an "item class"
                           //    //Player.Inventoty - List<Item>
                           //    //Heal??
                           //    player.Life += (player.Life / 5);
                           //    #endregion
                           //    //Leave the inner loop and get a new monster and room
                           //    reload = true;
                           //}
                           //break;//UNCIMMENT AFTER VILLIANS ARE CREATED

                        case "R":

                            Console.WriteLine("Run Away!");
                            //Console.WriteLine($"{monster.Name} attacks you as you flee!");//UNCOMMENT AFTER VILLIANS CREATED
                            //Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            reload = true; //generate a new monster and a new room
                            break;//exit 1 loop

                        case "P":

                            Console.WriteLine("Player:");
                            //Console.WriteLine(player);
                            Console.WriteLine("Monsters SLain: " + score);
                            break;

                        case "M":

                            Console.WriteLine("Monster");
                            //Console.WriteLine(monster);//UNCOMMENT AFTER VILLIANS/MONSTERS ARE CREATED
                            break;

                        case "X":
                        case "E":
                        case "Escape":
                            quit = true;
                            Console.WriteLine("No one likes a quitter...");
                            break;//exit both loops

                        default:
                            Console.WriteLine("Thou hast chosen an improper option. Triest thou again.");
                            break;
                    }//end switch
                    #endregion


                    //if (player.Life <= 0)//UNCOMMENT AFTER PLAYER IS CREATED
                    //{
                    //    Console.WriteLine("Dude......you died!\a");
                    //    //Quit = !quit; //flip the bool to whatever it isnt.
                    //    quit = true;
                    //}
                } while (!reload && !quit);
                #endregion
            } while (!quit);
            #endregion

            //Output the final score and say goodbye
            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."));

        }//end Main()

        #region Custom Methods

        private static string GetRoom()
        {
            string[] rooms =
            {
                "T",
                "Y",
                "Y",
                "",
                "A",
                "O",
                "Y",
                "O",
                "T",//CREATE ROOM DESCRIPTIONS
            };
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            string room = rooms[index];
            return room;
            //possible refactor
            //return rooms[new Random().Next(rooms.Length)];
        }//end GetRoom()

        #endregion
    }//end class
}// end namespace