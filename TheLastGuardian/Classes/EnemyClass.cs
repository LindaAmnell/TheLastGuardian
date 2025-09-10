
namespace TheLastGuardian;


public class Enemy
{
    public string Name;
    public int Hp;
    public int Damage;
    public int GoldReward;


    public Enemy(string name, int hp, int damage, int gold)
    {

        Name = name;
        Hp = hp;
        Damage = damage;
        GoldReward = gold;
    }

    public void Attack(Player p)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n⚡ {Name} attacks you!");
        Console.ResetColor();

        p.CurrentHp -= Damage;

        Console.WriteLine($"You lose {Damage} hp, current {p.CurrentHp}/{p.MaxHp} hp\n");

    }


}

