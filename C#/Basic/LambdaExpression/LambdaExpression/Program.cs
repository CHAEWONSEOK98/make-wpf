namespace LambdaExpression
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    var lambda = new LambdaTest();

        //    lambda.SayHello();

        //    Console.WriteLine(lambda.Add(1,2));

        //    Console.WriteLine();

        //    Console.Read();
        //}
        static void Main(string[] args)
        {
            var lambda = new LambdaTest();

            // LambdaTest에 있는 LambdaFunc 호출
            lambda.LambdaFunc(lambda.SayHello);

            Console.Read();
        }

        //public class LambdaTest
        //{
        //    public void SayHello()
        //    {
        //        Console.WriteLine("Hello");
        //    }

        //    public int Add(int a, int b)
        //    {
        //        return a + b;
        //    }

        //    public void LambdaFunc(Action action)
        //    {
        //        action();
        //    }
        //}
        public class LambdaTest
        {
            public void SayHello()
            {
                Console.WriteLine("Hello");
            }
            //() => 
            //{
            //    Console.WriteLine("Hello");
            //}

            //(int a, int b) =>
            //{
            //    return a + b;
            //}

            // Action : 매개 변수가 없고 값을 반환하지 않는 메서드를 캡슐화한다.
            // lambda.LambdaFunc(lambda.SayHello); 이 부분을 action 매개 변수로 받아서 action에 맞는 함수를 LambdaFunc 함수 바디에 있는 action(); 이 호출한다.
            // Console 에 Hello가 찍힌다.
            public void LambdaFunc(Action action)
            {
                action();
            }
        }
    }
}


/*
    lambda.LambdaFunc(lambda.SayHello);

    public void SayHello()
    {
        Console.WriteLine("Hello");
    }

    public void LambdaFunc(Action action)
    {
        action();
    }

    -------------------------------------
    
    lambda.LambdaFunc(() =>
    {
        Console.WriteLine("Hello");
    });

    public void LambdaFunc(Action action)
    {
        action();
    }
*/