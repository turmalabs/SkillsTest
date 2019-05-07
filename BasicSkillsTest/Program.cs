using System;
using System.Collections.Generic;

namespace BasicSkillsTest
{
    partial class Program
    {

        static void Main(string[] args)
        {
            // TEST RULES:  If you get stuck you may use Google to help you.  You are allowed
            // to use any .net framework namespace and methods to achieve results.  If a particular test
            // gives you issues move onto the next and come back to it at the end.
            
            Console.WriteLine("Test 1: FizzBuzz");

            // Write a program that prints the numbers from 1 to 100. But for multiples of three
            // print “Fizz” instead of the number and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.

            Test1();
            Console.ReadLine();

            Console.WriteLine("Test 2: String Reverse");
            // Reverse the string below so that it outputs: amrut

            var test2String = "turma";
            Console.WriteLine(Test2(test2String));
            Console.ReadLine();

            Console.WriteLine("Test 3: Highest value");
            // Output the highest value in the list

            var numberList = new List<int> { 1, 4, 4, 83, 22, 22, 90, 35 };
            Console.WriteLine(Test3(numberList));
            Console.ReadLine();

            Console.WriteLine("Test 4: Lowest value");
            // Output the lowest value in the list

            Console.WriteLine(Test4(numberList));
            Console.ReadLine();

            Console.WriteLine("Test 5: Distinct values");
            // Output the distinct values in the list

            Console.WriteLine(Test5(numberList));
            Console.ReadLine();

            Console.WriteLine("Test 6: Palindrome");
            // a palindrome is a word that reads the same backwards as forwards.
            // Complete the method so it accurately says if a word is a palendrome.
            // Method should ignore case

            var pal = "Deleveled";
            if (Test6(pal)) Console.WriteLine($"{pal} is a palindrome");
            else throw new Exception();

            pal = "oranges";
            if (!Test6(pal)) Console.WriteLine($"{pal} is not a palindrome");
            else throw new Exception();

            Console.WriteLine("Test 7: Inheritance");
            // For this test you must complete the 2 classes in Test7.cs following the instructions in comments.
            Test7();



        }


    }
}
