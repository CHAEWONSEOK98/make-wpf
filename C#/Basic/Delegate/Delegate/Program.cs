namespace Delegate
{
    public class TestClass
    {

    }
}

/*
Delegate
- 무엇 인지?

- 언제 쓰는지?
    - 함수를 담을 때
    - 예제1
        delegate void MyDelegate();

        public TestClass()
        {
            MyDelegate myDelegate;
            myDelegate = FuncTest;
            myDelegate();
        }

        public void FuncTest()
        {

        }
    
    - 예제2
        delegate int AddDelegate(int a, int b);

        public TestClass()
        {
            AddDelegate addDelegate = Add;
            addDelegate(1, 2);
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

- 왜 쓰는지? 중복을 방지하기 위해서
    - 예제1
        delegate int MyDelegate();

        public TestClass()
        {
            ShowMenu(GetAge_Korea);
            ShowMenu(GetAge_Japan);
        }

        void ShowMenu(MyDelegate GetAge)
        {
            int age = GetAge();

            if (age >= 20)
            {

            }
            else
            {

            }
        }

        private int GetAge_Korea()
        {
            // DB에서 현재 고객의 생년월일을 가져온다.
            // 현재 일시 - 생년월일 빼준다. +1

            return 0;
        }

        private int GetAge_Japan()
        {
            // DB에서 현재 고객의 생년월일을 가져온다.
            // 현재 일시 - 생년월일 빼준다.

            return 0;
        }
*/