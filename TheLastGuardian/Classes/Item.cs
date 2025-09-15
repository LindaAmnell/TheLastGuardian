namespace TheLastGuardian.Classes
{
    public class Item
    {
        public string Name;
        public int Price;
        public int Value;
        public string Effect;

        public void BuyItem(Player player, List<Item> list)
        {
            if (player.Glimmer < Price)
            {
                Console.WriteLine("⚠️ Not enough Glimmer!");
                return;
            }
            if (Effect == "Health")
            {
                if (player.CurrentHp >= player.MaxHp)
                {
                    Console.WriteLine("You don't have to buy this, your health is good!");
                    return;
                }
                player.CurrentHp += Value;
                if (player.CurrentHp > player.MaxHp) player.CurrentHp = player.MaxHp;
                Console.WriteLine($"💚 Boosted Health by {Value}! Current HP: {player.CurrentHp}/{player.MaxHp}");
            }
            else if (Effect == "MaxHealth")
            {
                player.MaxHp += Value;
            }
            else
            {
                player.Damage += Value;
                player.Weapon = Name;
                Console.WriteLine($"⚔️ Damage increased by {Value}! Current Damage: {player.Damage}");
            }
            Console.WriteLine($"💎 You bought: {Name}!");
            player.Glimmer -= Price;
        }
    }


}
