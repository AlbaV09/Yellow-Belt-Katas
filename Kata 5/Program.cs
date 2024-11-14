class Program
{
    static void Main()
    {
        static void AttackEnemy(string enemyName, int damage)
        {
            Console.WriteLine($"Attacked {enemyName} and dealt {damage} damage!");
        }

        static void HealPlayer(string playerName, int healAmount)
        {
            Console.WriteLine($"Player {playerName} healed {healAmount} health points!");
        }
        AttackEnemy("Goblin", 20);
        HealPlayer("Arin", 15);
    }
}
