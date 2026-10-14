using System;

class Program
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main()
    {
        Console.WriteLine("Please enter today's day of the week.");

        try
        {
            DayOfWeek current = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);
            Console.WriteLine($"Thank God it's {current}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Please enter an actual day of the week.");
        }
    }
}