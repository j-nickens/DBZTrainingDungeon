
using DBZDungeonLibrary;

namespace DBZTrainingDungeon
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Title / Introduction
            Console.Title = "======= Capsule Corp Training Dungeon =======";
            Console.WriteLine("@__\r\n  |  \"\"--.--.._                                             __..    ,--.\r\n  |       `.   \"-.'\"\"\\_...-----..._   ,--. .--..-----.._.\"\"|   |   /   /\r\n  |_   _    \\__   ).  \\           _/_ |   \\|  ||  ..    >  `.  |  /   /\r\n    | | `.   ._)  /|\\  \\ .-\"\"\"\":-\"   \"-.   `  ||  |.'  ,'`. |  |_/_  /\r\n    | |_.'   |   / \"\"`  \\  ===/  ..|..  \\     ||      < \"\"  `.  \"  |/__\r\n    `.      .    \\ ,--   \\-..-\\   /\"\\   /     ||  |>   )--   |    /    |\r\n     |__..-'__||__\\   |___\\ __.:-.._..-'_|\\___||____..-/  |__|--\"\"____/\r\n                           _______________________\r\n                          /                      ,'\r\n                         /      ___            ,'\r\n                        /   _.-'  ,'        ,-'   /\r\n                       / ,-' ,--.'        ,'   .'/\r\n                      /.'     `.         '.  ,' /\r\n                     /      ,-'       ,\"--','  /\r\n                          ,'        ,'  ,'    /\r\n                         ,-'      ,' .-'     /\r\n                      ,-'                   /\r\n                    ,:________________Seal_/\r\n\r\n");


            Console.WriteLine("On today's episode...Bulma and the Capsule Corp, created a prototype called \"The Capsule Corp Training Dungeon\" that may change the way the Z Fighters train and grow stronger! With the newest threat looming Trunks offers to give it a try......Little does he know once you enter you lose all powers. Leaving trunks one option, to go  into battle using only his sword....Will this be an effective way to train?...What kind of enemies will he find inside??? FIND OUT ON THIS EPISODE OF DRAGON BALL Z!!!\n");
            //ask how to format this to look better in the console
            
            #endregion

            #region Player Creation

            #region Character Creator
            //Let them choose their name

            //Show them a list of precreated Weapons (Weapon.PickWeapon())

            //Enum.GetValues<RAce>().ToList() -- see ClassicMonsters example in Enums.Cs

            //Could also show  list of pre created players
            #endregion

            int XP = 0;//player score


            //Weapon(Weapon.PickWeapon());
            Weapon w1 = new Weapon(1, 8, "The Brave Sword", 10, true, WeaponType.The_Brave_Sword);
            Console.WriteLine(w1);//Ask about how to add weapon choices.

            //Weapon w2 = new Weapon(1, 10, "The Z Sword", 7, true, WeaponType.Z_Sword);//Ask how to get this added in as an optional weapon
            //Add a switch for option to switch swords?? Do I need to make another weapon class in the Weapon.cs?

            Player player = new Player("Future Trunks", 70, 5, 40, Race.Hybrid, w1);

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
                            Console.WriteLine(player);
                            Console.WriteLine("Experience gained: " + XP);
                            break;

                        case "M":

                            Console.WriteLine("Villian");
                            //Console.WriteLine(monster);//UNCOMMENT AFTER VILLIANS/MONSTERS ARE CREATED
                            break;

                        case "X":
                        case "E":
                        case "Escape":
                            quit = true;
                            Console.WriteLine("Thanks for the training I feel Stronger already!!...");
                            break;//exit both loops

                        default:
                            Console.WriteLine("This is not an option. Are you ok? :) ");
                            break;
                    }//end switch
                    #endregion


                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude......you died!\a");
                        //Quit = !quit; //flip the bool to whatever it isnt.
                        quit = true;
                    }
                } while (!reload && !quit);
                #endregion
            } while (!quit);
            #endregion

            //Output the final score and say goodbye
            Console.WriteLine("You have gained: " + XP + "Training Experience" + (XP == 1 ? "." : "s.\n"));
            Console.WriteLine("\n@    _.\r\n                         ,-\" .\\,-\"`.\r\n                       ,:   . /,-.  `.\r\n                      /\"     :,-  `   \\\r\n                     |.    .`/,. `.    \\\r\n                    /  /  /_\\)/_\\       .\r\n                   .  .  /' / \\ \"\\\r\n                   |  : ,' .   . \\ \\\\ . |\r\n                   |  : || |   | | || . '\r\n                   \\__\\_bo..  ...bo)L L/\r\n    T R U N K S      |9|\\_*_\" \"_*_/|?T\r\n                     \\(` --- L --- ')/\r\n     (future)       .'`-|   ___   |-:\r\n               .---\"  -. .   =   ,   `.\r\n               \"\"-._ --./ \"-._.-\"|     \"-._\r\n                  .-\"-. \\  \\      \\   _..-<_\r\n              .--\"     ) `. \\   /  | :-\"..  \\\r\n           .-'_     \\ ,'  \\\\\"`.,'\"\"   \\   `  |\r\n          /    `.    | \"-. `   \\    |/\"    | \\\r\n              .  \\      _ \\:|   |  ,|.\"\"\"\"\"| /\r\n         /   :    |.-\"\"\" | \\|`._'_.  |`.  .( \\\r\n        /|  '     ||_  .' `:'        |: `v \\  |\r\n       / | :      |  \"\")  :|         |:  |  | |\r\n       |          /|   /  :|         |:  /  / )\r\n       (         | /_.|...:|         /  |  |  |\r\n      / \\        /_..-----\"'         \"\"\"-,-   |\r\n     |          /`--\\                   |\\  `.)\r\n     |         |     |                ,/ `. `.\\\r\n     /   _Seal_|      \"._..---\"\"\"\"---./\\ ` `. )");

        }//end Main()

        #region Custom Methods

        private static string GetRoom()
        {
            string[] rooms =
            {
                "This room, It looks just like Dr. Geros lab!!",
                "As I enter this room I soon realize, this is Korin's Tower...",
                "WHAT.... THIS IS THE HYPERBOLIC TIME CHAMBER!!!??",
                "How...This room is an exact replica of planet Namek!!",
                "This, this is Satan City how is this possible?",
                "I remember this place....The Kame house.",
                "This place must be otherworld .....there is an errie silence",
                "This can't be.....It's MAJIIN BUU's HOUSE!",
                "So here we are in the martial arts tournament arena!",
            };
            return rooms[new Random().Next(rooms.Length)];
            
        }//end GetRoom()

        #endregion
    }//end class
}// end namespace