internal class Sensor
{
    public void Detect(Product product)
    {
        Console.WriteLine("It has been Detected");

        product.Describe();
    }
}

