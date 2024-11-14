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
/*
Requirements
    Define a Player class with the following properties and methods:
        Properties:
            Name (string): The player's name.
            Health (int): The player’s health points.
            Level (int): The player’s level.
            Experience (int): The player’s experience points.
        Methods:
            Attack(int damage): A method that reduces an enemy’s health by a specified damage amount (you can display a message to simulate the attack).
            GainExperience(int exp): A method that increases the player’s experience by a specified amount and displays a message.
    Define an Enemy class with the following properties and methods:
        Properties:
            Type (string): The type of enemy (e.g., "Orc").
            Health (int): The enemy’s health points.
            Damage (int): The enemy’s attack damage.
        Methods:
            TakeDamage(int damage): A method that reduces the enemy’s health by a specified damage amount and displays a message if the enemy is defeated (i.e., Health <= 0).
    In the Main method:
        Create instances of Player and Enemy and initialize their properties.
        Call Attack on the player to attack the enemy.
        Call TakeDamage on the enemy to reduce its health.
        Call GainExperience on the player to add experience points.

Expected Outcome
The program should display messages showing the player attacking the enemy, the enemy taking damage, and the player gaining experience. For example

Player Arin attacks the Orc and deals 20 damage.
Orc takes 20 damage. Remaining Health: 30
Player Arin gains 50 experience points.

C# Features Used
    Classes with Methods: Methods within classes allow objects to have behaviors specific to their roles. Here, Attack, TakeDamage, and GainExperience provide actions that Player and Enemy can perform.
    Method Invocation on Objects: Calls methods on instances of Player and Enemy to simulate interactions, like attacking and taking damage.
    Conditional Logic in Methods: The TakeDamage method includes a conditional statement to check if the enemy’s health has reached zero.

*/