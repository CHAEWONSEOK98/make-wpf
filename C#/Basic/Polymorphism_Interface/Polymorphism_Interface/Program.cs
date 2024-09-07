namespace Polymorphism_Interface
{
    public class Test
    {
        public void TESTFUNC()
        {
            CharacterPoint characterPoint = new CharacterPoint();
            characterPoint.X = 10;
            characterPoint.Y = 20;

            GetPoint(characterPoint);

            BulletPoint bulletPoint = new BulletPoint();
            bulletPoint.X = 10;
            bulletPoint.Y = 20;

            GetPoint(bulletPoint);

            GetPoint(new EnemyPoint());
        }

        //public static string GetPoint(CharacterPoint p)
        //{
        //    return $"{p.X}, {p.Y}";
        //}
        //public static string GetPoint(BulletPoint p)
        //{
        //    return $"{p.X}, {p.Y}";
        //}
        public static string GetPoint(IPoint p)
        {
            return $"{p.X}, {p.Y}";
        }
    }

    public interface IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class CharacterPoint : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
    }

    public class  BulletPoint : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
    }

    public class EnemyPoint : IPoint
    {
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

/*
여러개의 Class에서 공통 속성을 뽑아서 일반 상속,
추상 클래스, 인터페이스 등을 이용해서 다형하게 만드는 작업을 추상화라고 한다.
*/