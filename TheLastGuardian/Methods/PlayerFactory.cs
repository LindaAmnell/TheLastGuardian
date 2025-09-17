namespace TheLastGuardian.Methods
{
    public static class PlayerFactory
    {
        public static Player CreatePlayer()
        {
            Player player = null;
            Console.Write("The Traveler's Light shines upon you... What shall you be called, Guardian? ");
            string name = Console.ReadLine();

            while (player == null)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n═════════ Choose Your Class ═════════\n");
                Console.ResetColor();
                Console.WriteLine("[1] 🏹 Hunter");
                Console.WriteLine("   • Masters of agility and precision.");
                Console.WriteLine("   • Strike from the shadows with deadly accuracy.\n");

                Console.WriteLine("[2] 🛡️ Titan");
                Console.WriteLine("   • Unbreakable defenders of the Light.");
                Console.WriteLine("   • Wield brute strength and indomitable will.\n");

                Console.WriteLine("[3] 🔮 Warlock");
                Console.WriteLine("   • Scholars of the arcane mysteries.");
                Console.WriteLine("   • Bend the Traveler’s power to heal allies or devastate foes.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("═════════════════════════════════════\n");
                Console.ResetColor();
                Console.Write("Choose your class (1-3): ");
                string chosenClass = Console.ReadLine();
                Console.Clear();

                switch (chosenClass)
                {
                    case "1":
                        player = new Player(name, "🏹 Hunter", 160, 25, 20);
                        break;

                    case "2":
                        player = new Player(name, "🛡️ Titan", 155, 28, 20);
                        break;

                    case "3":
                        player = new Player(name, "🔮 Warlock", 150, 26, 20);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice! Please enter 1 - 3.\n");
                        Console.ResetColor();
                        break;
                }
            }
            StoryManager.IntroStory(player);
            return player;
        }
    }
}
