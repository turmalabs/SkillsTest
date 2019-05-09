using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BasicSkillsTest
{
    // There are 2 classes TextInput & Numeric intput:

    // TextInput: Tracks all text input into a string
    // NumericInput: Tracks only numeric input into a string

    // Implement the class TextInput that contains: 
    //   • Public method void Add(char c) - adds the given character to the current value
    //   • Public method string GetValue() - returns the current value

    // Implement the class NumericInput that: 
    //   • Inherits Textlnput 
    //   • Overrides the Add method so that each non-numeric character is ignored.

    // Uncomment the test lines in Test7 method once implemented.  The expected output should be the same

    partial class Program
    {
        static void Test7()
        {
            //TextInput input = new NumericInput();
            //input.Add('1');
            //input.Add('a');
            //input.Add('0');
            //Console.WriteLine(input.GetValue()); //expected output 10

            //TextInput input2 = new TextInput();
            //input2.Add('1');
            //input2.Add('a');
            //input2.Add('0');
            //Console.WriteLine(input2.GetValue()); //expected outut 1a0
        }
    }

    public class TextInput
    {
    }

    public class NumericInput
    {

    }

}
