using Microsoft.VisualBasic;
using System;
using System.Threading;
using System.Xml.Linq;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


namespace Recipe
{
    public partial class Info
    {
        public string Name { get; }
        public int Servings { get; }
        private string[] Ingredients;
        private int[] Count;

        public Info(string name, int serves, int Ming)
        {
            Name = name;
            Servings = serves;
            Ingredients = new string[Ming];
            Count = new int[Ming];
        }
    }




    public partial class Cooking

    {
        public void AddIngredient(string ingredient)
        {
            

        }

        public void PrintRecipe()
        {


        }
    }
}