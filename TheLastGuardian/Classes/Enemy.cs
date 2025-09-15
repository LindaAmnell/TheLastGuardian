
namespace TheLastGuardian;
public class Enemy
{
    public string Name;
    public int Hp;
    public int Damage;
    public int GlimmerReward;
    public string Description;

    public Enemy(string name, int hp, int damage, int glimmer)
    {
        Name = name;
        Hp = hp;
        Damage = damage;
        GlimmerReward = glimmer;
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

