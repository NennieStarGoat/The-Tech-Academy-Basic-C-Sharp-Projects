using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClass
{
    internal class Math
    {
        //Void method that takes two integers
        public void MultiplyThrice(int firstnum, int secondnum)
        {
            //Multiplies the two integers three times
            int result = (firstnum * secondnum) * 3;

            //Displays the second integer
            Console.WriteLine($"The second number is: {secondnum}");
        }
    }
}
