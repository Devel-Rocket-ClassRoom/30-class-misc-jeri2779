using System;

class StringHelper
{
    public static string CleanAndUpper(string input)
    {
        return input.Trim().ToUpper();
    }

    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return   new string(chars);
    }

    public static bool IsNullOrEmpty(string input)
    {
        return string .IsNullOrEmpty(input);
    }
}
