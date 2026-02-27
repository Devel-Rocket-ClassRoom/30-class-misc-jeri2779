using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");
Console.WriteLine("## 과제 1: 부분 클래스 기본 문법");

Person person = new Person();
person.Name = "홍길동";
person.Age = 25;
person.Print();


Console.WriteLine("## 과제 2: 부분 클래스 사용 예제");

Hello hello = new Hello();
hello.Hi();
hello.Bye();


Console.WriteLine("## 과제 3: 정적 클래스 기본 문법");

int sum = Calculator.Add(10, 20);
int diff = Calculator.Subtract(30, 10);
int product = Calculator.Multiply(5, 6);

Console.WriteLine($"덧셈: {sum}");
Console.WriteLine($"뺄셈: {diff}");
Console.WriteLine($"곱셈: {product}");


Console.WriteLine("## 과제 4: 유틸리티 클래스 만들기");
string text = "  hello world  ";
Console.WriteLine(StringHelper.CleanAndUpper(text));
Console.WriteLine(StringHelper.Reverse("Hello"));
Console.WriteLine(StringHelper.IsNullOrEmpty(""));
double sqrt = Math.Sqrt(16);
double pow = Math.Pow(2, 3);
int Max = Math.Max(10, 20);
int Min = Math.Min(10, 20); 

Console.WriteLine("## 과제 5: 닷넷의 정적 클래스 예시");
Console.WriteLine($"제곱근: {sqrt}");
Console.WriteLine($"거듭제곱: {pow}");
Console.WriteLine($"최댓값: {Max}");
Console.WriteLine($"최솟값: {Min}");

Console.WriteLine("## 과제 6: StringBuilder의 메서드 체이닝");
 
 

StringBuilder sb = new StringBuilder();
sb.Append("Hello");
    sb.Append("");
sb.Append("World");
string result1  = sb.ToString();

string result2 = new StringBuilder()
    .Append("Hello")
    .Append(" ")
    .Append("World")
    .ToString();

Console.WriteLine(result1);
Console.WriteLine(result2);

Console.WriteLine("## 과제 7: 메서드 체이닝 직접 구현하기");
string message = new MessageBuilder()
    .AddText("안녕하세요!")
    .AddNewLine("")
    .AddText("반갑습니다.")
    .AddSpace(" ")
    .AddText("좋은 하루 되세요.")
    .Build();

Console.WriteLine("## 과제 8: 불변 객체와 메서드 체이닝");
Point point = new Point(0, 0)
    .MoveBy(10, 10)
    .MoveBy(20, 20)
    .MoveBy(30, 30);
Console.WriteLine("## 과제 9: 문자열 메서드 체이닝");

string text1 = " Hello World ";
string result = text1
    .Trim()
    .ToLower()
    .Replace(" ", "_");
Console.WriteLine(result);

Console.WriteLine("## 과제 10: 가변 형식");
MutableCircle circle = new MutableCircle(10);
Console.WriteLine($"반지름: {circle.Radius}");

circle.Radius = 20;  // 직접 변경 가능
Console.WriteLine($"반지름: {circle.Radius}");

Console.WriteLine("## 과제 11: 불변 형식");
ImmutableCircle circle1 = new ImmutableCircle(10);
Console.WriteLine($"원본 반지름: {circle1.Radius}");

// circle1.Radius = 20;  // 오류! 읽기 전용

ImmutableCircle circle2 = circle1.WithRadius(20);  // 새 객체 생성
Console.WriteLine($"새 원 반지름: {circle2.Radius}");
Console.WriteLine($"원본 반지름: {circle1.Radius}");


Console.WriteLine("## 과제 12: readonly 필드를 사용한 불변 형식");
Player player1 = new Player("용사", 1);
Player player2 = player1.LevelUp();

Console.WriteLine($"player1: {player1.Name}, 레벨 {player1.Level}");
Console.WriteLine($"player2: {player2.Name}, 레벨 {player2.Level}");

Console.WriteLine("# 과제 13: 닷넷의 불변 형식 예시");

string original = "Hello";
string modified = original.ToUpper();
Console.WriteLine($"원본: {original}");       
Console.WriteLine($"수정본: {modified}");

Console.WriteLine("## 과제 14: 종합 - 부분 클래스로 게임 캐릭터 구현");
Character hero = new Character("용사");
Console.WriteLine($"{hero.Name} - 레벨: {hero.Level}, 체력: {hero.Health}");

hero.TakeDamage(30);
hero.Heal(10);
 
Console.WriteLine("## 과제 15: 종합 - 정적 클래스로 유틸리티 만들기");
int damage = GameHelper.CalculateDamage(10, 5);
bool alive = GameHelper.IsAlive(50);
string status = GameHelper.GetHealthStatus(30, 100);

Console.WriteLine($"계산된 데미지: {damage}");
Console.WriteLine($"생존 여부: {alive}");
Console.WriteLine($"체력 상태: {status}");

Console.WriteLine("## 과제 16: 종합 - 불변 형식과 메서드 체이닝 결합");
Vector2D result0 = new Vector2D(1, 1)
    .Add(2, 3)       // (3, 4)
    .Multiply(2)     // (6, 8)
    .Add(-1, -2);    // (5, 6)

Console.WriteLine($"결과 벡터: {result0}");
