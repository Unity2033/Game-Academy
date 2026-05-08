internal class Program
{
    static void Main(string[] args)
    {
        #region 의존 역전 원칙
        // 추상화는 세부 사항에 의존해서는 안되며,세부 사항이
        // 추상화에 의존할 수 있도록 설계해야 하는 원칙입니다.

        Character character = new Character();

        character.Acquire(new Knife());
        character.Acquire(new Grenade());

        Console.WriteLine("Press Spacebar to switch weapons.");

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Spacebar)
                {
                    character.Swap();
                }

                if (key == ConsoleKey.A)
                {
                    character.Use();
                }
            }
        }

        #endregion
    }
}

