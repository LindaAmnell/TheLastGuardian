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
                string choseClass = Console.ReadLine();
                Console.Clear();

                switch (choseClass)
                {
                    case "1":
                        player = new Player(name, "🏹 Hunter", 120, 15, 30);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nWelcome, Guardian {player.Name}!");
                        Console.WriteLine($"You walk the path of the {player.PlayerClass}.");
                        Console.WriteLine("Silent, swift, and deadly, the darkness will never see you coming.\n");
                        Console.ResetColor();
                        break;

                    case "2":
                        player = new Player(name, "🛡️ Titan", 130, 20, 30);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\nWelcome, Guardian {player.Name}!");
                        Console.WriteLine($"You walk the path of the {player.PlayerClass}.");
                        Console.WriteLine("A bulwark against the Darkness , your Light is unbreakable.\n");
                        Console.ResetColor();
                        break;

                    case "3":
                        player = new Player(name, "🔮 Warlock", 125, 17, 30);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"\nWelcome, Guardian {player.Name}!");
                        Console.WriteLine($"You walk the path of the {player.PlayerClass}.");
                        Console.WriteLine("Mystic, scholar, and wielder of cosmic fire , the Light bends to your will.\n");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice! Please enter 1 - 3.\n");
                        Console.ResetColor();
                        break;
                }
            }

            Console.WriteLine("Press any key to continue your journey...");
            Console.ReadKey();
            Console.Clear();
            return player;
        }
    }
}
