using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string number = Console.ReadLine();
            float new_number = Convert.ToSingle(number) * 50f;
            Console.WriteLine(number + " times 50 = " + new_number);
            Console.WriteLine("Please enter another number.");
            string second_number = Console.ReadLine();
            float new_second_number = Convert.ToSingle(second_number) + 25f;
            Console.WriteLine(second_number + " + 25 = " + new_second_number);
            Console.WriteLine("Please enter another number.");
            string third_number = Console.ReadLine();
            float new_third_number = Convert.ToSingle(third_number) / 12.5f;
            Console.WriteLine(third_number + " divided by 12.5 = " + new_third_number);
            Console.WriteLine("Please enter another number.");
            string fourth_number = Console.ReadLine();
            bool isgreater = Convert.ToSingle(fourth_number) > 50;
            Console.WriteLine(isgreater);
            Console.WriteLine("Please enter another number.");
            string fifth_number = Console.ReadLine();
            float new_fifth_number = Convert.ToSingle(fifth_number) % 7;
            Console.WriteLine(fifth_number + " divided by 7 has a remainder of " + new_fifth_number);
            Console.ReadLine();

        }
    }
}
