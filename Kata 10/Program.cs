public interface ISpeakable
{
    void Speak();
}

public interface IDamageable
{
    void TakeDamage(int damage);
}
public class Player : IDamageable
{
    public string name;
    public int health;
    public int level;
    
    public void Attack(string nameEnemy)
    {
        Console.WriteLine($"Player {name} attacks {nameEnemy}.");
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        Console.WriteLine($"Player {name} takes {damage} damage. Remaining health: {health}");
    }
}

public class Enemy :IDamageable
{
    public string type;
    public int health;
    public int damage;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Console.WriteLine($"{type} is defeated");
        }
        else
        {
            Console.WriteLine($"{type} takes {damage} damage. Remaining Health: {health}");
        }
    }
}

public class NPC : ISpeakable
{
    public string name;
    public string dialogue;

    public void Speak()
    {
        Console.WriteLine($"{name} says: {dialogue}.");
    }
}

public class Merchant : ISpeakable
{
    public string name;
    public List<string> inventory = new List<string>();
    
    public void Speak()
    {
        Console.WriteLine($"{name} says: Ready to trade!");
    }

    public void Trade()
    {
        Console.WriteLine("Player Inventory:");
        foreach (string item in inventory)
        {
            Console.Write($"{item} ");
        }
    }
}
class Program
{
    static void Main()
    {
        Player player = new Player();
        player.name = "Arin";
        player.health = 100;
        player.level = 1;
        
        Enemy enemy = new Enemy();
        enemy.type = "Goblin";
        enemy.health = 50;
        enemy.damage = 10;
        
        NPC npc = new NPC();
        npc.name = "NPC";
        npc.dialogue = "Welcome to our village!";
        
        Merchant merchant = new Merchant();
        merchant.name = "Merchant";
        merchant.inventory.Add("Sword");
        merchant.inventory.Add("Shield");
        merchant.inventory.Add("Potion");
       
        player.Attack("Goblin");
        enemy.TakeDamage(20);

        List<ISpeakable> speakables = new List<ISpeakable> { npc, merchant };
        foreach (ISpeakable speakable in speakables)
        {
            speakable.Speak();
        }
        
        List<IDamageable> damageables = new List<IDamageable> { player, enemy };
        foreach (IDamageable damageable in damageables)
        {
            damageable.TakeDamage(10);
        }
    }
}