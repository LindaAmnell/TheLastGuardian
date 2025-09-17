using TheLastGuardian.Methods;

namespace TheLastGuardian;
public class Player
{
    public string Name;
    public string PlayerClass;
    public int CurrentHp;
    public int MaxHp;
    public int Damage;
    public int Glimmer;
    public string Weapon;

    public Player(string name, string playerClass, int curentHp, int damage, int glimer)
    {
        Name = name;
        PlayerClass = playerClass;
        CurrentHp = curentHp;
        MaxHp = curentHp;
        Damage = damage;
        Glimmer = glimer;
        Weapon = "Scout Rifle";
    }

    public void Status()
    {
        Console.WriteLine($"{Name} your hp: {CurrentHp}/{MaxHp} and you have {Glimmer} glimmer and your damage is: {Damage}.");
        Console.WriteLine("Press any key to continue your journey...");
        Console.ReadKey();
    }

    public void Rest(Player player)
    {
        int rest = 10;
        int restPrice = 5;
        bool noHealing = false;
        ReusableMethods.IncreaseHp(player, restPrice, rest, "Rest", ref noHealing);
    }

    public void Heal(Enemy enemy, Player player)
    {
        int heal = 15;
        int healPrice = 10;
        bool noHealing = false;
        ReusableMethods.IncreaseHp(player, healPrice, heal, "Heal", ref noHealing);

        if (noHealing)
        {
            return;
        }
        enemy.Attack(player);
    }

    public bool EarnGold(Enemy enemy, bool isDead)
    {
        if (isDead == true)
        {
            Glimmer += enemy.GlimmerReward;
            Console.WriteLine($"You have ernd {enemy.GlimmerReward} glimmer, your total is {Glimmer} glimmer.\n");

        }
        return isDead;
    }

    public void Attack(Enemy e)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"⚔️ {Name} attacks {e.Name} with their weapon {Weapon}!");
        Console.ResetColor();

        e.Hp -= Damage;
        if (e.Hp <= 0)
        {
            Console.WriteLine($"\n{e.Name} is defeated! 💀\n");
        }
        else
        {
            Console.WriteLine($"{e.Name} loses {Damage} HP, remaining HP: {e.Hp}");
        }
    }
}

