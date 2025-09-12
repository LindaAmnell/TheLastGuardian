using TheLastGuardian.Classes;

namespace TheLastGuardian.Methods
{
    public static class Store
    {

        public static void OpenStore(Player player)
        {

            bool isShopping = true;

            List<Item> items = new List<Item>
            {
                new Item { Name="Bright Health Synth", Price=15, Value=20, Effect="Health" },
                new Item { Name="Major Health Synth", Price=40, Value=50, Effect="Health" },
                new Item { Name="Gjallarhorn", Price=50, Value=10, Effect="Damage" },
                new Item { Name="Ace of Spades", Price=45, Value=8, Effect="Damage" },
                new Item { Name="Suros Regime", Price=35, Value=6, Effect="Damage" }
            };

            while (isShopping)
            {
                Console.Clear();
                ReusableMethods.HeadLineText(player);
                Console.WriteLine("The Light guides you to the Tower...");
                Console.WriteLine("Here, Guardians prepare for the battles ahead.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"💰 You have {player.Glimmer} Glimmer.\n");
                Console.ResetColor();
                ReusableMethods.MenyLine(player);

                Console.WriteLine("═════════ The Tower Market ═════════\n");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {items[i].Name} - price: {items[i].Price} - raise: {items[i].Effect} by {items[i].Value}");
                }
                Console.WriteLine("[6] Quit");
                Console.WriteLine("Choose your upgrades wisely, for the darkness grows stronger with every step.\n");
                ReusableMethods.MenyLine(player);
                Console.Write("What do you choose: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int pick))
                {
                    Console.WriteLine("Invalid choies, Pleas enter a number (1-6).");
                    Console.ReadKey();
                    continue;
                }
                if (pick >= 1 && pick <= items.Count)
                {
                    Item item = items[pick - 1];
                    item.BuyItem(player, items);
                    Console.WriteLine("Press any key to continue your journey...");
                    Console.ReadKey();
                }
                else if (pick == 6)
                {
                    isShopping = false;
                }

            }
        }
    }
}
