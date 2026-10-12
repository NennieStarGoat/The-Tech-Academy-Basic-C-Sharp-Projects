using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates the class
            Math mathObject = new Math();

            //calls method
            mathObject.MultiplyThrice(4, 17);

            //calls method specifying parameters by name
            mathObject.MultiplyThrice(firstnum: 4, secondnum: 17);

            //keeps the console window open
            Console.ReadLine();
        }

    }
}