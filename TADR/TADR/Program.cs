using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A simple program that asks several questions and stores the user inputs. Converts necessary inputs to integers or booleans, depending.
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("\nStudent Daily Report");
            Console.WriteLine("\n\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("\nWhat course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("\nWhat page number?");
            string page = Console.ReadLine();
            int page_number = Convert.ToInt16(page);
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool help_needed = Convert.ToBoolean(help);
            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("\nHow many hours did you study today?");
            string hours = Console.ReadLine();
            int hours_studied = Convert.ToInt32(hours);
            Console.WriteLine("\n\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
