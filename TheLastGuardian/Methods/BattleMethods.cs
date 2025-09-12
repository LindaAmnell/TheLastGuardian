namespace TheLastGuardian.Methods
{
    public static class BattleMethods
    {
        public static void PlayerVsEnemy(Player player, Enemy enemy)
        {
            ReusableMethods.HeadLineText(player);
            enemy = EnemyFactory.RandomEnemy();
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
                ReusableMethods.MenyLine(player);
                Console.WriteLine("Choose your next action wisely:");
                Console.WriteLine("1: Strike the enemy ⚔️");
                Console.WriteLine("2: Restore your light ✨");
                Console.WriteLine("3: Retreat 🏃\n");
                ReusableMethods.MenyLine(player);

                Console.Write("Choose you action: ");
                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        ReusableMethods.HeadLineText(player);
                        player.Attack(enemy);
                        if (enemy.Hp <= 0)
                        {
                            isDead = true;
                            player.EarnGold(enemy, isDead);
                            Console.WriteLine("Press any key to continue your journey...");
                            Console.ReadKey();
                            return;
                        }
                        enemy.Attack(player);
                        if (player.CurrentHp <= 0)
                        {
                            Console.WriteLine($"{player.Name} has been defeated...");
                            Console.WriteLine("Press any key to continue your journey...");
                            Console.ReadKey();
                            isDead = true;
                            return;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        ReusableMethods.HeadLineText(player); ;
                        player.Heal(enemy, player);


                        break;
                    case "3":
                        Console.Clear();
                        ReusableMethods.HeadLineText(player);
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
