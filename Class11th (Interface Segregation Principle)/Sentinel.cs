internal class Sentinel : IDamageable, ITalkable
{
    private int health;

    public Sentinel()
    {
        health = 100;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        Console.WriteLine("Health : " + health);
    }

    public void Talk()
    {
        Console.WriteLine("I would like to report");
    }
}

