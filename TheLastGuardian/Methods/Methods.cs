namespace TheLastGuardian.Methods
{
    public static class Methods
    {

        public static Player CreatePlayer()
        {
            Player p = new Player();
            Console.Write("Choose your name: ");
            p.Name = Console.ReadLine();
            bool validChoice = true;

            while (validChoice)
            {
                Console.Write("\nChoose your class: \n1: 🏹Hunter\n2: 🛡️Titan\n3: 🔮Warlock:\n");
                string choseClass = Console.ReadLine();

                switch (choseClass)
                {
                    case "1":
                        p.PlayerClass = "🏹Hunter";
                        p.MaxHp = 120;
                        p.CurrentHp = p.MaxHp;
                        p.Damage = 15;
                        validChoice = false;
                        break;
                    case "2":
                        p.PlayerClass = "🛡️Titan";
                        p.MaxHp = 130;
                        p.CurrentHp = p.MaxHp;
                        p.Damage = 20;
                        validChoice = false;
                        break;
                    case "3":
                        p.PlayerClass = "🔮Warlock";
                        p.MaxHp = 125;
                        p.CurrentHp = p.MaxHp;
                        p.Damage = 17;
                        validChoice = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter 1 - 3.");
                        break;
                }
            }

            Console.Clear();
            ReusableMethods.HeadLineText();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome, Guardian {p.Name}!\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You have chosen the mighty class: {p.PlayerClass}.\n");
            Console.ResetColor();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            return p;
        }


        public static Enemy RandomEnemy()
        {
            Enemy[] enemies =
        {
             new Enemy("Fallen Dreg", 50, 10, 20),
             new Enemy("Hive Thrall", 55, 20, 25),
             new Enemy("Vex Goblin", 55, 15, 20),
             new Enemy("Cabal Legionary", 40, 20, 20),
             new Enemy("Taken Knight", 70, 10, 20),
        };

            Random randomEnemy = new Random();
            Enemy random = enemies[randomEnemy.Next(enemies.Length)];

            return random;
        }


        public static void PlayerVsEnemy(Player player, Enemy enemy)
        {
            ReusableMethods.HeadLineText();
            enemy = Methods.RandomEnemy();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"⚔️ {enemy.Name} has entered the battlefield!");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{player.PlayerClass} {player.Name} prepares to face {enemy.Name}!\n");
            Console.ResetColor();
            Console.WriteLine("The battle is upon you, Guardian!\n");


            bool isDead = false;
            while (!isDead)
            {

                Console.WriteLine("Choose your next action wisely:");
                Console.WriteLine("1: Strike the enemy ⚔️");
                Console.WriteLine("2: Restore your light ✨");
                Console.WriteLine("3: Retreat 🏃\n");


                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        ReusableMethods.HeadLineText();
                        player.Attack(enemy);
                        if (enemy.Hp <= 0)
                        {
                            isDead = true;
                            player.EarnGold(enemy, isDead);
                            Console.ReadKey();
                            return;
                        }
                        enemy.Attack(player);
                        if (player.CurrentHp <= 0)
                        {
                            Console.WriteLine($"{player.Name} has been defeated...");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            isDead = true;
                            return;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        ReusableMethods.HeadLineText(); ;
                        player.Heal(enemy, player);


                        break;
                    case "3":
                        Console.Clear();
                        ReusableMethods.HeadLineText();
                        isDead = true;
                        Console.WriteLine($"You have choosen to run");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please choos 1-3");
                        break;


                }



            }
        }


    }
}
