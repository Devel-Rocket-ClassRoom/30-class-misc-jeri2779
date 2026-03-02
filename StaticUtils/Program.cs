using System;
using static System.Math;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== Clamp 테스트 ===");
// 메서드의 결과값을 출력(Console.WriteLine)에 전달하거나 변수에 담아야 합니다.
Console.WriteLine($"Clamp(-10, 0, 100) = {GameUtils.Clamp(-10, 0, 100)}");
Console.WriteLine($"Clamp(50, 0, 100) = {GameUtils.Clamp(50, 0, 100)}");
Console.WriteLine($"Clamp(150, 0, 100) = {GameUtils.Clamp(150, 0, 100)}");

Console.WriteLine("\n=== GetPercentage 테스트 ===");
Console.WriteLine($"GetPercentage(75, 100) = {GameUtils.GetPercentage(75, 100)}%");
Console.WriteLine($"GetPercentage(30, 200) = {GameUtils.GetPercentage(30, 200)}%");

Console.WriteLine("\n=== IsInRange 테스트 ===");
Console.WriteLine($"IsInRange(50, 0, 100) = {GameUtils.IsInRange(50, 0, 100)}");
Console.WriteLine($"IsInRange(-5, 0, 100) = {GameUtils.IsInRange(-5, 0, 100)}");
//GameUtils.Clamp(-10, 0, 100) = 0;
public static class GameUtils
{
    
    public static int Clamp(int value, int min, int max)
    {
        if (value < min) return min;
        if(value > max) return max;
        return value;
    }
    public static int GetPercentage(int current, int max)
    {
        if (max == 0) return 0; // 0으로 나누기 방지 (Exception Handling)
        // (부분 / 전체) * 100
        return (int)((double)current / max * 100);
    }
    public static bool IsInRange(int value, int min, int max)
    {
        return value >= min && value <= max;
    }

}
