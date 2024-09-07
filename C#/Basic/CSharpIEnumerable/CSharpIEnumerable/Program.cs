using System.Collections;

/*
 * IEnumerable : 어떤 자료에 순차적으로 접근해서 어떠한 행동을 하고 싶을 때 구현하는 것.
 * 사용 : foreach, linq, etc..
*/

namespace CSharpIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>();

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            // 직접 구현해서 사용할 수 있는 IEnumerable - foreach
            var bc = new Bookcase();

            bc.Add(new Book()
            {
                ID = 0,
                지은이 = "한글 지은이",
                출판사 = "한글 출판사",
            });
            bc.Add(new Book()
            {
                ID = 1,
                지은이 = "일본 지은이",
                출판사 = "일본 출판사",
            });
            foreach (Book item in bc)
            {
                Console.WriteLine(item.지은이);
            }
        }
    }

    class Book
    {
        public int ID { get; set; }
        public string 지은이 { get; set; } = string.Empty;
        public string 출판사 {  set; get; } = string.Empty;
    }

    class Bookcase : IEnumerable
    {
        ArrayList _books = new ArrayList();

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public IEnumerator GetEnumerator()
        {
            return _books.GetEnumerator();
        }
    }
}