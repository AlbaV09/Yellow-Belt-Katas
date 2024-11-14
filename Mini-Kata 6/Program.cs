class Program
{
    static void Main()
    {
        string[] enemyNames = { "Goblin", "Orc", "Troll" };

        Console.WriteLine("Enemies:");
        foreach (string enemy in enemyNames)
        {
            Console.WriteLine(enemy);
        }
        Console.WriteLine();
        List<string> playerInventory = new List<string> { "Sword", "Shield", "Potion" };
        Console.WriteLine("Player Inventory:");
        foreach (string item in playerInventory)
        {
            Console.WriteLine(item);
        }
        playerInventory.Add("Helmet");
        Console.WriteLine();
        Console.WriteLine("Updated Inventory:");
        foreach (string item in playerInventory)
        {
            Console.WriteLine(item);
        }
    }
}