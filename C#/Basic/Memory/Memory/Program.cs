// 스택 메모리

/*
 * 스택 메모리는 함수 호출과 관련된 변수, 지역 변수 및 매개 변수를 저장하는 데 사용
 * 메모리는 후입선출(LIFO) 방식으로 관리
 * 메모리 할당과 해제가 매우 빠르며, 스택 포인터를 이용해 데이터에 빠르게 접근할 수 있다
 * 메모리 할당과 헤제는 자동으로 이루어지며, 이는 스택 프레임 내부의 변수가 함수 실행이 완료될 때 자동으로 삭제되기 때문
 * 스택 메모리의 크기는 한정되어 있으며, 지정된 최대 크기를 초과하면 스택 오버플로우(스택에 더 이상 공간이 없을 때 발생하는 오류)가 발생할 수 있다.
 * 
*/

/*
 * 값 형식
 * 값 형식(Value Types)은 C#과 같은 프로그래밍 언어에서 사용되는 데이터 형식 중 하나
 * 변수에 직접 값을 저장하며, 이러한 변수는 스택(Stack) 메모리에 저장
 * 
 * C#에서 기본적으로 제공하는 값 형식
 * bool
 * byte
 * char
 * decimal
 * double
 * enum
 * float
 * int
 * long
 * sbyte
 * short
 * struct
 * uint
 * ulong
 * ushort
*/

//void MyMethod()
//{
//    int i = 123; // 4바이트 스택 메모리 할당
//    bool b = true;
//    float f = 10.5f;
//    char c = 'a';
//}

/*
 * 힙 메모리
 * 프로그램 실행 도중 동적으로 할당되고 해제되는 변수와 데이터를 저장하는 데 사용된다
 * 메모리는 동적으로 할당되어 관리된다
 * 메모리 할당과 해제는 명시적으로 프로그래머가 수행해야 하며, 이는 메모리 누수(할당된 메모리를 해제하지 않아서 사용할 수 없게 되는 현상)와 같은 문제를 발생시킬 수 있다
 * (C#은 Managed Language라서 GC가 사용되지 않는 메모리를 수집해준다)
 * 스택 메모리보다 더 큰 메모리를 할당할 수 있다
 * 스택 메모리와 달리 여러 개의 포인터가 동시에 가리킬 수 있으므로 자유도가 높다
*/

/*
 * C# 참조형식(reference types)
 * 
 * 클래스(class), 인터페이스(interface), 배열(array), 대리자(delegate), 객체(object), 문자열(string)
*/

void MyMethod()
{
    var p1 = new Person() { Name = "채귤", Age = 27 };
    var p2 = new Person() { Name = "이귤", Age = 26 };
    object obj = 123;
}

class Person
{
    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }
}