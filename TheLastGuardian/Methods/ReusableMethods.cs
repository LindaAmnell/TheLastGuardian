namespace TheLastGuardian.Methods
{
    public static class ReusableMethods
    {
        public static void HeadLineText(Player player)
        {
            if (player == null)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("🛡️ Destiny: The Last Guardian 🛡️\n");
                Console.ResetColor();
                return;
            }
            if (player.PlayerClass == "🏹 Hunter")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("🛡️ Destiny: The Last Guardian 🛡️\n");
                Console.ResetColor();
            }
            else if (player.PlayerClass == "🛡️ Titan")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("🛡️ Destiny: The Last Guardian 🛡️\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("🛡️ Destiny: The Last Guardian 🛡️\n");
                Console.ResetColor();
            }
        }
        public static void MenyLine(Player player)
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

            Console.WriteLine("═══════════════════════════════════");
            Console.ResetColor();
        }

        public static void IncreaseHp(Player player, int price, int increaseHp, string actionName, ref bool noHeal)
        {

            if (player.CurrentHp >= player.MaxHp)
            {
                Console.WriteLine("Your HP is already full!");
                Console.WriteLine("Press any key to continue your journey...");
                noHeal = true;
                Console.ReadKey();
                return;
            }

            if (player.Glimmer < price)
            {
                Console.WriteLine($"Too little Glimmer! You only have {player.Glimmer}.\n");
                Console.WriteLine("Press any key to continue your journey...");
                Console.ReadKey();
                noHeal = true;
                return;
            }

            player.CurrentHp += increaseHp;
            noHeal = false;

            if (player.CurrentHp > player.MaxHp)
            {
                player.CurrentHp = player.MaxHp;
            }

            if (actionName == "Rest")
            {
                Console.WriteLine($"You rested and recovered {increaseHp} HP. Current HP: {player.CurrentHp}/{player.MaxHp}");
                player.Glimmer -= price;
                Console.WriteLine($"- {price} glimmer, {player.Glimmer} left ");
                Console.WriteLine("Press any key to continue your journey...");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine($"You healed yourself and restored {increaseHp} HP. Current HP: {player.CurrentHp}/{player.MaxHp}");
                player.Glimmer -= price;
                Console.WriteLine($"- {price} glimmer, {player.Glimmer} left ");

            }
        }
    }
}
