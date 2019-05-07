using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        var letters = word.split();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}