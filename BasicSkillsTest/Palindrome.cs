using System;
using System.Linq;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        var lowerWord = word.ToLower();
        var reverseWord = string.Join("", lowerWord.Reverse());

        return reverseWord == lowerWord;
    }


}