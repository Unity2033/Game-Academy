internal class Grenade : Weapon
{
    public Grenade() 
    {
        damage = 100;
        range = 10;        
    }

    public override void Attack()
    {
        Console.WriteLine("Throw a Grenade");
    }
}

