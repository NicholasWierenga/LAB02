public class Program1
{
    public static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        int num1;

        do
        {
            Console.WriteLine(name + ", please enter an integer from 1 to 100: ");
            num1 = int.Parse(Console.ReadLine());

            while (num1 < 1 || num1 > 100)
            {
                Console.WriteLine("Invalid number.");
                Console.WriteLine(name + ", please enter an integer from 1 to 100: ");
                num1 = int.Parse(Console.ReadLine());
            }

            if (num1 % 2 == 1) // checks for odd
            {
                if (num1 < 60)
                    Console.WriteLine(name + ", your integer is odd and less than 60.");

                else
                    Console.WriteLine(name + ", your integer is odd and greater than 60.");
            }

            else if (num1 < 25) // All valid evens inclusively between 2 and 24 are less than 25. Lower evens would've prompted user for new number.
                Console.WriteLine(name + ", your integer is even and less than 25.");

            else if (num1 >= 26 && num1 <= 60)
                Console.WriteLine(name + ", your integer is even and between 26 and 60 inclusive.");

            else
                Console.WriteLine(name + ", your integer is even and greater than 60.");

            Console.WriteLine("Do you want to enter a new number, " + name + "? Enter " + "yes" + " or anything else to exit.");

        } while (Console.ReadLine().ToLower() == "yes");

    }
}