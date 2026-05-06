internal abstract class Product
{
    protected int price;
    protected string menuel;

    public void Describe()
    {
        Console.WriteLine("Price : " + price);
        Console.WriteLine("Menuel : " + menuel);

        Console.WriteLine();
    }
}

