public class Player 
{
    public string name;
    public int health;
    public int level;
    public int experience;
    
    public void Attack(int damage)
    {
        Console.WriteLine($"Player {name} attacks and deals {damage} damage.");
    }

    public void GainExperience(int exp)
    {
        experience += exp;
        Console.WriteLine($"Player {name} gained {exp} experience.");
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
class Program
{
    static void Main()
    {
        Player player = new Player();
        player.name = "Arin";
        player.health = 100;
        player.level = 1;
        player.experience = 100;
        
        Enemy enemy = new Enemy();
        enemy.type = "Goblin";
        enemy.health = 50;
        enemy.damage = 10;
       
        player.Attack(20);
        enemy.TakeDamage(20);
        player.GainExperience(50);
    }
}