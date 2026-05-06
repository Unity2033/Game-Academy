internal class Seller : ISellable, ITalkable
{
    public void Sell()
    {
        Console.WriteLine("1. Potion");
        Console.WriteLine("2. Matchestick");
        Console.WriteLine("3. Humus Stone");
    }

    public void Talk()
    {
        Console.WriteLine("What would you like to buy?");
    }
}

