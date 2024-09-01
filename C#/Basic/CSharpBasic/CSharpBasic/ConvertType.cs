// 형변환(Type Casting)

#region 암시적 변환 (컴파일러가 자동으로 형변환)
//int i = 10;
//double d = i;

//Button button = new Button();
//Control control = button;

//Console.WriteLine(button.GetString());
//Console.WriteLine(control.GetString());

//class Control
//{
//    public virtual string GetString() => "Control";
//}

//class Button : Control
//{
//    public override string GetString()
//    {
//        return base.GetString() + " in Button";
//    }
//}
#endregion


#region 명시적 변환 (프로그래머가 직접 강제로 형변환)
//double d = 10.5;
//int i = (int)d;

//Console.WriteLine(i);
#endregion

/*
Boxing
- 값 형식을 참조 형식으로 변환
- 값 형식을 참조 형식으로 변환하기 때문에 추가적인 메모리 할당 및 복사 작업이 필요 -> 성능에 부담을 줄 수 있는 작업

Unboxing
- 참조 형식을 값 형식으로 변환

Control control = (Control)obj;
Console.WriteLine(control.GetString());

타입이 명확하지 않을 때 Unboxing하면 오류가 발생.
    -> as operator 사용하여 해결 : 참조 형식을 다른 참조 형식으로 변환. 캐스트 실패 시 null 반환.
Button button = (Button)obj;
obj 값이 Button 타입이 맞다면 버튼을 넘겨주고 obj 값이 Button 타입이 아니라면 null을 반환. 
*/
#region Boxing, Unboxing

//object obj = 123;
//int i = (int)obj;

//void BoxingUnboxing(object obj)
//{

//    Button? button = obj as Button;

//    if(button != null)
//    {
//        Console.WriteLine(button.GetString());
//    }
//    else
//    {
//        Console.WriteLine("button is null");
//    }
//}

//BoxingUnboxing(new Control());

//class Control
//{
//    public virtual string GetString() => "Control";
//}

//class Button : Control
//{
//    public override string GetString()
//    {
//        return base.GetString() + " in Button";
//    }
//}
#endregion


#region Convert : 데이터 타입 변환
//string s = "10.5";
//double d = Convert.ToDouble(s);

//Console.WriteLine(d);
#endregion


#region Parse : 데이터 타입 변환
//string s = "10.5";
//double d = double.Parse(s);

//Console.WriteLine(d);
#endregion


#region 변환이 가능한지 유효성을 확인한 후 데이터를 넘기고 싶을 때 TryParse : bool 값을 반환
//string s = "10.5";
//double.TryParse(s, out double d);
//int.TryParse(s, out int i);

//Console.WriteLine($"d = {d}");
//if(int.TryParse(s, out int t))
//{
//    Console.WriteLine($"i = {i}");
//}
//else
//{
//    Console.WriteLine("i is null");
//}
#endregion


#region 배열 형 변환
List<Animal> animals = new()
{
    new Cat {Name = "냐옹이1"},
    new Cat {Name = "냐옹이2"},
    new Cat {Name = "냐옹이3"},
    new Dog {Name = "멍멍이1"},
    new Dog {Name = "멍멍이2"},
    new Dog {Name = "멍멍이3"},
    new Pig {Name = "꿀꿀이1"},
    new Pig {Name = "꿀꿀이2"},
    new Pig {Name = "꿀꿀이3"},
};

// Cast : 타입이 하나라도 변환할 수 없는 것이 있다면 오류를 반환.
// List<Cat> cats = animals.Cast<Cat>().ToList();

// OfType : 해당 요소에서 형식 매개변수 타입에 맞는 타입만 열거형태로 넘겨준다. 타입을 반환할 것이 없을 때 값을 넘겨주지 않는다 > Cast보다 좀더 안정적.
List<Cat> cats = animals.OfType<Cat>().ToList();

foreach (Cat cat in cats)
{
    Console.WriteLine(cat.Name);
}



class Animal
{
    public string Name { get; set; } = default!;
}

class Cat : Animal { }

class Dog : Animal { }

class Pig : Animal { }

class Tiger : Animal { }
#endregion