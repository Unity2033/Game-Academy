namespace Program
{
    internal class Program
    {
        delegate float Opetation(float x, float y);

        static float Add(float x, float y)
        {
            return x + y;
        }

        static float Substract(float x, float y)
        {
            return x - y;
        }

        static float Multiply(float x, float y)
        {
            return x * y;
        }

        static float Divide(float x, float y) 
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            #region 대리자
            // 특정한 함수를 가진 함수를 참조할 수 있는 참조 타입입니다.

            Opetation opetation;

            opetation = Add;

            Console.WriteLine(opetation(5, 5));

            opetation = Substract;

            Console.WriteLine(opetation(5, 5));

            opetation = Multiply;

            Console.WriteLine(opetation(5, 5));

            opetation = Divide;

            Console.WriteLine(opetation(5, 5));

            #endregion

        }
    }
}

