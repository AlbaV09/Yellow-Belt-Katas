public class Player 
{
    public string name;
    private int health = 80;
    private int level = 0;
    private int experience = 0;
    
    public int Health
    {
        get { return health; }
        private set 
        {
            if (value >= 0)
                health = value;
        }
    }

    public int Level
    {
        get { return level; }
        private set 
        {
            if (value > 0)
                level = value;
        }
    }

    public int Experience
    {
        get { return experience; }
        private set
        {
            if (value >= 0)
                experience = value;
        }
    }
    public void Attack(int damage)
    {
        Console.WriteLine($"Player {name} attacks and deals {damage} damage.");
    }

    private void LevelUp()
    {
        while (experience >= 100)
        {
           level++;
           experience -= 100;
           Console.WriteLine($"Congratulations! You leveled up to Level {level}.");
        }
    }
 
    public void GainExperience(int exp)
    {
        experience += exp;
        LevelUp();
        Console.WriteLine($"Player {name} gained {exp} experience.");
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player();
        player.name = "Arin";
        
        player.GainExperience(50);
        player.GainExperience(60);
    }
}
/*
 * Requirements

    Update the Player class:
        Private Fields: Convert Health, Level, and Experience to private fields.
        Public Properties: Create public properties for Health, Level, and Experience with appropriate getters and setters.
            Ensure Health can be accessed but only modified within the class itself.
            Ensure Level and Experience can be set by other classes but have validation in the setter to prevent negative values.
        Create a private method LevelUp() that increases Level by 1 and resets Experience to 0.
        Update GainExperience(int exp) to call LevelUp() if Experience reaches or exceeds 100.
    In the Main method:
        Create a Player instance and call GainExperience to test the level-up logic.
        Try directly setting Health outside the class to verify encapsulation (this should produce an error if Health is correctly encapsulated).

Expected Outcome

The program should display messages showing experience gain and leveling up when experience reaches 100. Example output:

Player gains 50 experience points.
Player gains 60 experience points.
Congratulations! You leveled up to Level 2.

*/