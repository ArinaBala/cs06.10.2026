namespace Intro;


internal class Program
{
    static void Main(string[] args)
    {

        Console.Write("enter the first number: ");
        int d1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the second number: ");
        int d2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the third number: ");
        int d3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the fourth number: ");
        int d4 = Convert.ToInt32(Console.ReadLine());

       
        if (d1 >= 0 && d1 <= 9 && d2 >= 0 && d2 <= 9 && d3 >= 0 && d3 <= 9 && d4 >= 0 && d4 <= 9)
        {
            int resultNumber = d1 * 1000 + d2 * 100 + d3 * 10 + d4;
            Console.WriteLine($"formed number result: {resultNumber}");
        }
        else
        {
            Console.WriteLine("error! you must enter single nums (from 0 to 9).");
        }

        Console.WriteLine("\n 2task");
        Console.Write("enter the value (number): ");
        double val = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter the percentage: ");
        double percent = Convert.ToDouble(Console.ReadLine());
        double percentResult = (val * percent) / 100;
        Console.WriteLine($"result ({percent}% of {val}): {percentResult}");
    }
}

