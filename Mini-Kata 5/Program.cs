class Program
{
    static void Main()
    {
        static void Attack(int damage)
        {
            Console.WriteLine($"Player dealt {damage} damage!");
        }

        static void Heal(int healAmount)
        {
            Console.WriteLine($"Player healed {healAmount} health points!");
        }
        Attack(15);
        Heal(10); 
    }
}