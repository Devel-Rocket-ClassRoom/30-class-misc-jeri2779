using Microsoft.VisualBasic;
using RecipeApp;
using System;
using System.Threading;
using System.Xml.Linq;

// README.md를 읽고 아래에 코드를 작성하세요.
// 비빔밥 레시피 생성
Recipe bibimbap = new Recipe("비빔밥", 2, 10);
bibimbap.AddIngredient("밥");
bibimbap.AddIngredient("고추장");
bibimbap.AddIngredient("계란");
bibimbap.AddIngredient("시금치");
bibimbap.AddIngredient("당근");

bibimbap.PrintRecipe();

Console.WriteLine($"\n계란 포함: {bibimbap.HasIngredient("계란")}");
Console.WriteLine($"소고기 포함: {bibimbap.HasIngredient("소고기")}");

// 샌드위치 레시피 생성
Recipe sandwich = new Recipe("샌드위치", 1, 5);
sandwich.AddIngredient("빵");
sandwich.AddIngredient("햄");
sandwich.AddIngredient("치즈");

sandwich.PrintRecipe();

namespace RecipeApp
{
    // --- Recipe.Info.cs 부분 ---
    public partial class Recipe // 클래스 이름을 Recipe로 통일!
    {
        public string Name { get; }
        public int Servings { get; }
        private string[] ingredients; // 재료를 담는 창고
        private int Count;           // 현재 몇 개가 담겼는지 알려주는 카운터

        public Recipe(string name, int serves, int maxIngredients)
        {
            Name = name;
            Servings = serves;
            ingredients = new string[maxIngredients];
            Count = 0; // 처음에는 0개
        }
    }

    // --- Recipe.Cooking.cs 부분 ---
    public partial class Recipe // 클래스 이름 동일하게!
    {
        public void AddIngredient(string ingredient)
        {
            // Count(현재 담긴 수)가 ingredients.Length(창고 총 크기)보다 작아야 추가 가능
            if (Count < ingredients.Length)
            {
                ingredients[Count] = ingredient; // 현재 순서에 재료 넣기
                Count++; // 다음 칸으로 이동
            }
            else
            {
                Console.WriteLine("재료 칸이 가득 찼습니다.");
            }
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"\n=== {Name} ({Servings}인분) ===");
            Console.WriteLine("재료:");
            for (int i = 0; i < Count; i++) // 저장된 개수(Count)만큼 반복
            {
                Console.WriteLine($"  {i + 1}. {ingredients[i]}");
            }
        }

        public bool HasIngredient(string ingredient)
        {
            for (int i = 0; i < Count; i++)
            {
                if (ingredients[i] == ingredient) return true;
            }
            return false;
        }
    }
}
 