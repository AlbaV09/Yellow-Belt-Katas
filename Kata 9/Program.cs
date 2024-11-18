public class Player 
{
    public string name;
    public int health;
    public int level;
    
    public void Attack(string nameEnemy)
    {
        Console.WriteLine($"Player {name} attacks {nameEnemy}.");
    }
    
}

public class Enemy
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

public class NPC()
{
    public string name;
    public string dialogue;

    public void Speak()
    {
        Console.WriteLine($"{name} speaks and says {dialogue}.");
    }
}

public class Merchant()
{
    public string name;
    public List<string> inventory = new List<string>();

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
        npc.Speak();
        merchant.Trade();
    }
}