using TheLastGuardian.Classes;

namespace TheLastGuardian.Methods
{
    public static class Store
    {

        public static void OpenStore(Player p)
        {

            bool isShopping = true;

            List<Item> items = new List<Item>
            {
                new Item { Name="Bright Health Synth", Price=15, Value=20, Effect="Health" },
                new Item { Name="Major Health Synth", Price=40, Value=50, Effect="Health" },
                new Item { Name="Gjallarhorn", Price=50, Value=15, Effect="Damage" },
                new Item { Name="Ace of Spades", Price=45, Value=12, Effect="Damage" },
                new Item { Name="Suros Regime", Price=35, Value=10, Effect="Damage" },
                new Item { Name="Heart of the Guardian", Price=30, Value=20, Effect="MaxHealth" }
            };

            while (isShopping)
            {
                Console.Clear();
                ReusableMethods.HeadLineText(p);
                Console.WriteLine("The Light guides you to the Tower...");
                Console.WriteLine("Here, Guardians prepare for the battles ahead.\n");
                Console.WriteLine($"Your HP: {p.CurrentHp}/{p.MaxHp} | Damage: {p.Damage}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"💰 You have {p.Glimmer} Glimmer.\n");
                Console.ResetColor();

                if (p.PlayerClass == "🏹 Hunter")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (p.PlayerClass == "🛡️ Titan")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                Console.WriteLine("═════════ The Tower Market ═════════\n");
                Console.ResetColor();

                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {items[i].Name} | raise: {items[i].Effect} increased by {items[i].Value}  | price: {items[i].Price}");
                }
                Console.WriteLine($"[{items.Count + 1}] Quit");
                Console.WriteLine("Choose your upgrades wisely, for the darkness grows stronger with every step.\n");
                ReusableMethods.MenyLine(p);
                Console.Write("What do you choose: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int pick))
                {
                    Console.WriteLine($"Invalid choice, please enter a number (1-{items.Count + 1}).");
                    Console.ReadKey();
                    continue;
                }
                if (pick >= 1 && pick <= items.Count)
                {
                    Item item = items[pick - 1];
                    item.BuyItem(p, items);
                    Console.WriteLine("Press any key to choose more or leave...");
                    Console.ReadKey();
                }
                else if (pick == items.Count + 1)
                {
                    isShopping = false;
                }

            }
        }
    }
}
