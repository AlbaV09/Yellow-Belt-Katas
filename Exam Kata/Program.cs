public interface ISpeakable
{
    void Speak();
}
public interface ITradeable
{
    void Trade();
}
public interface IDamageable
{
    void TakeDamage(int damage);
    bool IsAlive();
}
public class Player : IDamageable
{
    public string Name { get; set; }
    public int Health { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;
        Level = 1;
        Experience = 0;
    }

    public void Attack(Enemy enemy)
    {
        Console.WriteLine($"{Name} attacks the {enemy.Type} for 20 damage.");
        enemy.TakeDamage(20);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Health left: {Health}");
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void Heal()
    {
        Health += 20;
        Console.WriteLine($"{Name} heals 20 health. Current health: {Health}");
    }

    public void GainExperience(int xp)
    {
        Experience += xp;
        Console.WriteLine($"{Name} gains {xp} experience points.");
    }
}

public class Enemy : IDamageable
{
    public string Type { get; }
    public int Health { get; private set; }
    public int Damage { get; }

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine($"{Type} is defeated!");
        }
        else
        {
            Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}

public class NPC : ISpeakable
{
    public string Name { get; }
    public string Dialogue { get; }

    public NPC(string name, string dialogue)
    {
        Name = name;
        Dialogue = dialogue;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: {Dialogue}");
    }
}

public class Merchant : ISpeakable, ITradeable
{
    public string Name { get; }
    public List<string> Inventory { get; }

    public Merchant(string name)
    {
        Name = name;
        Inventory = new List<string> { "Sword", "Shield", "Potion" };
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Take a look at my wares.");
    }

    public void Trade()
    {
        Console.WriteLine("Available items: " + string.Join(", ", Inventory));
    }
}


class Game
{
    private Player player;
    private Random random = new Random();

    public void Start()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        player = new Player(name);

        Console.WriteLine($"{player.Name} says: Ready for battle!");

        while (player.IsAlive())
        {
            Encounter();
            if (!player.IsAlive())
            {
                Console.WriteLine("Game Over. You have been defeated.");
                break;
            }
        }
    }

    private void Encounter()
    {
        int encounterType = random.Next(1, 4);
        switch (encounterType)
        {
            case 1:
                EnemyEncounter();
                break;
            case 2:
                NPCEncounter();
                break;
            case 3:
                MerchantEncounter();
                break;
        }
    }

    private void EnemyEncounter()
    {
        Enemy enemy = new Enemy("Goblin", 30, 5);
        Console.WriteLine($"A wild {enemy.Type} appears with {enemy.Health} health and {enemy.Damage} damage!");

        while (enemy.IsAlive() && player.IsAlive())
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                player.Attack(enemy);
                if (enemy.IsAlive())
                {
                    Console.WriteLine($"The {enemy.Type} attacks {player.Name} for {enemy.Damage} damage.");
                    player.TakeDamage(enemy.Damage);
                }
            }
            else if (choice == "2")
            {
                player.Heal();
            }
        }

        if (!enemy.IsAlive())
        {
            player.GainExperience(30);
        }
    }

    private void NPCEncounter()
    {
        NPC npc = new NPC("Villager", "Welcome to our village!");
        npc.Speak();
    }

    private void MerchantEncounter()
    {
        Merchant merchant = new Merchant("Shopkeeper");
        merchant.Speak();
        merchant.Trade();
    }
}

class Program
{
    static void Main()
    {
        Game game = new Game();
        game.Start();
    }
}
