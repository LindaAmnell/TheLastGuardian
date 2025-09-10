namespace TheLastGuardian.Methods
{
    public static class AdventureChoice
    {
        public static bool Choice(Enemy enemy, Player player, bool isGameOver)
        {
            Console.Clear();
            ReusableMethods.HeadLineText();
            Console.WriteLine("What do you whant to do: ");
            Console.WriteLine("1: Adventure");
            Console.WriteLine("2: Rest");
            Console.WriteLine("3: Status");
            Console.WriteLine("4: Quit\n");
            string choice = Console.ReadLine().ToLower();


            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Methods.PlayerVsEnemy(player, enemy);
                    break;
                case "2":
                    player.Rest();
                    break;
                case "3":
                    player.Status();
                    break;
                case "4":
                    Console.WriteLine("You have choos to quite");
                    isGameOver = true;
                    Console.WriteLine("Thanks for playing!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please choos 1-4");
                    break;

            }
            //Console.WriteLine("Press any key to continue");
            //Console.ReadKey();
            return isGameOver;

        }

    }
}
