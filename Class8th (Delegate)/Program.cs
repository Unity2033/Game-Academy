internal class Program
{
    delegate float Operation(float x, float y);

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

    static void Execute(Operation operation)
    {
        float x = 10.0f;
        float y = 2.5f;

        float result = operation(x, y);

        Console.WriteLine(result);
    }

    static void Main(string[] args)
    {
        #region 대리자
        // 특정한 함수를 가진 함수를 참조할 수 있는 참조 타입입니다.

        Execute(Add);
        Execute(Substract);
        Execute(Multiply);
        Execute(Divide);

        #endregion

    }
}

