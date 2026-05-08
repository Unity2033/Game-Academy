internal class Slime : Enemy
{
    public Slime() 
    {
        health = 50;
    }

    public override void Attack()
    {
        Console.WriteLine("Slime Attack");
    }

    public override void Patrol()
    {
        Console.WriteLine("move left and right");
    }
}

