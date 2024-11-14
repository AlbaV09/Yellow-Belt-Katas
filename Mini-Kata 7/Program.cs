public class Player 
{
    public string name;
    public int health;
    public int level;
}

public class Enemy
{
    public string type;
    public int health;
    public int damage;
}
class Program
{
    static void Main()
    {
       Player player = new Player();
       player.name = "Arin";
       player.health = 100;
       player.level = 1;
       
       Console.WriteLine($"Player Info:\nName: {player.name}\nHealth: {player.health}\nLevel: {player.level}");

       Enemy enemy = new Enemy();
       enemy.type = "Goblin";
       enemy.health = 50;
       enemy.damage = 10;
       
       Console.WriteLine($"\nEnemy Info:\nType: {enemy.type}\nHealth: {enemy.health}\nDamage: {enemy.damage}");
    }
}