// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please give a radius");
        //string input = Console.ReadLine();
        //Console.WriteLine(input);
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Area: " + (Math.PI * Math.Pow(radius, 2)));
        Console.WriteLine("Circumference: " + (2 * Math.PI * radius));
    }
}

