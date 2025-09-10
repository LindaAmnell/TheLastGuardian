namespace TheLastGuardian;
public class Player
{
    public string Name;
    public string PlayerClass;
    public int CurrentHp;
    public int MaxHp;
    public int Damage;
    public int Gold;

    public Player()
    {
        Gold = 20;

    }

    public void Status()
    {
        Console.WriteLine($"{Name} your hp is: {CurrentHp}/{MaxHp} and you have colected {Gold} gold.");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    public void Rest()
    {
        int heal = 10;
        if (CurrentHp < MaxHp)
        {
            CurrentHp += heal;
            if (CurrentHp > MaxHp)
            {
                CurrentHp = MaxHp;
            }

            Console.WriteLine($"You heald yourself whit´{heal} hp, current hp is {CurrentHp}/{MaxHp}");

        }
        else
        {
            Console.WriteLine($"You tried to heal but your HP is already full!");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
    public void Heal(Enemy enemy, Player player)
    {
        int heal = 10;
        if (CurrentHp < MaxHp)
        {
            CurrentHp += heal;
            if (CurrentHp > MaxHp)
            {
                CurrentHp = MaxHp;
            }

            Console.WriteLine($"You heald yourself whit´{heal} hp, current hp is {CurrentHp}/{MaxHp}");
            enemy.Attack(player);
        }
        else
        {
            Console.WriteLine($"You tried to heal but your HP is already full!");
        }
    }

    public bool EarnGold(Enemy enemy, bool isDead)
    {
        if (isDead == true)
        {
            Gold += enemy.GoldReward;
            Console.WriteLine($"you ernd {enemy.GoldReward} gold");
            Console.WriteLine($"your total gold is {Gold}");
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

