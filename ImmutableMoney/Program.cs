 

//// README.md를 읽고 아래에 코드를 작성하세요.
//# 불변 형식 Money 클래스

//게임에서 화폐를 다루는 불변 클래스 `Money`를 구현하세요.

//`Money` 클래스는 다음 특징을 가집니다:

//**속성 * *

//- `Gold`: 골드(읽기 전용)
//- `Silver`: 실버(읽기 전용)

//* *생성자 * *

//- `Money(int gold, int silver)`: 골드와 실버로 초기화

//**메서드 (모두 새 Money 객체를 반환)**

//- `Add(int gold, int silver)`: 화폐 추가
//- `Subtract(int gold, int silver)`: 화폐 차감(0 이하가 되지 않도록)
//- `ToString()`: "X골드 Y실버" 형식으로 반환

//> 불변 형식이므로 원본 객체는 변경되지 않고, 연산 결과로 새 객체가 생성됨

//## 예상 실행 결과

//```
//=== 초기 화폐 ===
//지갑: 100골드 50실버

//=== 화폐 추가 ===
//추가 후: 150골드 80실버
//원본 지갑: 100골드 50실버

//=== 화폐 차감 ===
//차감 후: 80골드 20실버
//원본 지갑: 100골드 50실버

//=== 메서드 체이닝 ===
//결과: 120골드 30실버
//```

using System;
using static System.Math;


Console.WriteLine("=== 초기 화폐 ===");
Money wallet = new Money(100, 50);
Console.WriteLine($"지갑: {wallet}");

Console.WriteLine("\n=== 화폐 추가 ===");
Money addedWallet = wallet.Add(50, 30);
Console.WriteLine($"추가 후: {addedWallet}");
Console.WriteLine($"원본 지갑: {wallet}"); // 원본은 유지됨 (불변성)

Console.WriteLine("\n=== 화폐 차감 ===");
Money subtractedWallet = wallet.Subtract(20, 30);
Console.WriteLine($"차감 후: {subtractedWallet}");
Console.WriteLine($"원본 지갑: {wallet}");

Console.WriteLine("\n=== 메서드 체이닝 ===");
// Add 실행 결과(새 객체)에 바로 Subtract 호출
Money chainResult = wallet.Add(50, 0).Subtract(30, 20);
Console.WriteLine($"결과: {chainResult}");
public class Money
{
    public int Gold { get; }
    public int Silver { get; }
    public Money(int gold, int silver)
    {
        Gold = Max(0, gold);
        Silver = Max(0, silver);
    }
    // 화폐 추가: 현재 값을 바탕으로 '새로운' Money 객체 생성
    public Money Add(int gold, int silver)
    {
        return new Money( Gold + gold,  Silver + silver);
    }
    public Money Subtract(int gold, int silver)
    {
       return new Money(Gold - gold, Silver - silver);
    }
    public override string ToString()
    {
        return $"{Gold}골드 {Silver}실버";
    }
}

