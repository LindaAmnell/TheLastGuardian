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
    //public int Mana;
    //public int MaxMana;
    //public int ManaDamage;
    //public string ManaAtackName;

    public Player(string name, string playerClass, int curentHp, int damage, int glimer)
    {
        Name = name;
        PlayerClass = playerClass;
        CurrentHp = curentHp;
        MaxHp = curentHp;
        Damage = damage;
        Glimmer = glimer;
    }

    public void Status()
    {
        Console.WriteLine($"{Name} your hp is: {CurrentHp}/{MaxHp} and you have colected {Glimmer} gold.");
        Console.WriteLine("Press any key to continue your journey...");
        Console.ReadKey();
    }

    public void Rest(Player player)
    {
        int rest = 10;
        int restPrice = 5;
        ReusableMethods.IncreaseHp(player, restPrice, rest, "Rest");
    }
    public void Heal(Enemy enemy, Player player)
    {
        int heal = 15;
        int healPrice = 10;
        ReusableMethods.IncreaseHp(player, healPrice, heal, "Heal");
        enemy.Attack(player);
    }

    public bool EarnGold(Enemy enemy, bool isDead)
    {
        if (isDead == true)
        {
            Glimmer += enemy.GlimmerReward;
            Console.WriteLine($"you ernd {enemy.GlimmerReward} gold");
            Console.WriteLine($"your total gold is {Glimmer}");
        }
        return isDead;
    }

    public void Attack(Enemy e)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"⚔️ {Name} strikes {e.Name}!");
        Console.ResetColor();

        e.Hp -= Damage;
        if (e.Hp <= 0)
        {
            Console.WriteLine($"{e.Name} is defeated! 💀");
        }
        else
        {
            Console.WriteLine($"{e.Name} loses {Damage} HP, remaining HP: {e.Hp}");
        }
    }
}

