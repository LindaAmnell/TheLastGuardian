namespace TheLastGuardian.Methods
{
    public class AdventureChoice
    {
        public bool Choice(Enemy enemy, Player player, bool isGameOver)
        {
            Console.Clear();
            ReusableMethods.HeadLineText(player);
            Console.WriteLine($"[Fought enemies: {EnemyFactory.battleCount}]\n");
            if (EnemyFactory.bossCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Next fight is a Boss!");
                Console.ResetColor();
            }

            if (EnemyFactory.battleCount != 0 && EnemyFactory.battleCount % 10 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ Enemies grow stronger as you progress!");
                Console.ResetColor();
            }
            ReusableMethods.MenyLine(player);

            Console.WriteLine(" What will you do next, Guardian?\n ");
            Console.WriteLine(" [1] Adventure");
            Console.WriteLine(" [2] Rest");
            Console.WriteLine(" [3] Status");
            Console.WriteLine(" [4] Store");
            Console.WriteLine(" [5] Quit \n");

            ReusableMethods.MenyLine(player);

            Console.Write("Choose your action: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    BattleMethods.PlayerVsEnemy(player, enemy);
                    break;
                case "2":
                    player.Rest(player);
                    break;
                case "3":
                    player.Status();
                    break;
                case "4":
                    Store.OpenStore(player);
                    break;
                case "5":
                    Console.WriteLine("You have chosen to quit");
                    isGameOver = true;
                    Console.WriteLine("Thanks for playing!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please choos 1-5");
                    break;

            }
            return isGameOver;

        }

    }
}
