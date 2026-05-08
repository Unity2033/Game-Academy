internal class Knife : Weapon
{
    public Knife()
    {
        range = 1;
        damage = 10;
    }

    public override void Attack()
    {
        Console.WriteLine("Knife Stab");
    }
}

