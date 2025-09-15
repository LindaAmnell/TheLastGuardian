namespace TheLastGuardian.Methods
{
    public static class StoryManager
    {
        public static void IntroStory(Player player)
        {

            if (player.PlayerClass == "🏹 Hunter")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

            }
            else if (player.PlayerClass == "🛡️ Titan")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

            }
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("              The Last Guardian");
            Console.WriteLine("══════════════════════════════════════════\n");
            Console.ResetColor();

            Console.WriteLine($"The City watches as a new Guardian rises...");
            Console.WriteLine($"Chosen by the Traveler’s Light, {player.Name}, you are a {player.PlayerClass}.\n");

            switch (player.PlayerClass)
            {
                case "🏹 Hunter":
                    Console.WriteLine("Silent as the night, your enemies will fall before they even know you were there.");
                    Console.WriteLine("From the ruins of Earth to the far reaches of the system, your path is one of precision and cunning.\n");
                    break;

                case "🛡️ Titan":
                    Console.WriteLine("You are the wall that shall never crumble. A defender of humanity.");
                    Console.WriteLine("When the Darkness advances, you will stand tall, unshaken, and unbroken.\n");
                    break;

                case "🔮 Warlock":
                    Console.WriteLine("You wield the secrets of the universe as both weapon and shield.");
                    Console.WriteLine("The arcane bends to your will, and through knowledge, you will master the battlefield.\n");
                    break;
            }

            Console.WriteLine("But the Darkness stirs once more...");
            Console.WriteLine("Old enemies rise from the shadows, and whispers speak of a great threat looming beyond the stars.\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your journey begins now, Guardian.\n");
            Console.ResetColor();

            Console.WriteLine("Press any key to step into the fray...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
