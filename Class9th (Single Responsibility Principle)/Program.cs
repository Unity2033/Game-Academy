internal class Program
{
    static void Main(string[] args)
    {
        #region 단일 책임 원칙
        // 클래스는 하나의 기능으로 수정될 수 있도록 설계해야 하는 원칙입니다.

        User user = new User("error@google.com", "Internet9");

        Persistence persistence = new Persistence();

        Authenticate authenticate = new Authenticate(persistence);

        persistence.Save(user);

        bool result = authenticate.Execute(user);

        if (result)
        {
            Console.WriteLine("Login Success");
        }
        else
        {
            Console.WriteLine("Login Failure");
        }

        #endregion

    }
}

