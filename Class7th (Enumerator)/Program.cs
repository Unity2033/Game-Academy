internal class Program
{
    static void Main(string[] args)
    {
        #region 열거자
        // 여러 개의 항목으로 이루어진 데이터 집합에서 각 요소를 하나씩 
        // 순서대로 꺼내 사용할 수 있도록 해주는 객체입니다.

        Inventory<Item> inventory = new Inventory<Item>();

        Item knife = new Item();
        Item potion = new Item();

        knife.Name = "Knife";
        knife.Level = 15;
        knife.Bound = true;

        potion.Name = "Potion";
        potion.Level = 1;
        potion.Bound = false;

        inventory.Add(knife);
        inventory.Add(potion);

        foreach (Item item in inventory)
        {
            Console.WriteLine("Item Name : " + item.Name);
            Console.WriteLine("Item Level : " + item.Level);
            Console.WriteLine("Item Bound : " + item.Bound);

            Console.WriteLine();
        }

        #endregion

    }
}

