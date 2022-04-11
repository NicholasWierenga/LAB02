using System;


namespace DeliverableOne
{
    class DeliverableOne
    {
        static void Main(string[] args)
        {

            string response;

            do
            {
                Console.WriteLine("How many people are we making PB and J sandwiches for?");

                decimal numPeople = decimal.Parse(Console.ReadLine());

                Console.WriteLine("You need: \n");
                Console.WriteLine("    " + numPeople * 2 + " slices of bread");
                Console.WriteLine("    " + numPeople * 2 + " tablespoons of peanut butter");
                Console.WriteLine("    " + numPeople * 4 + " teaspoons of jelly \n");
                Console.WriteLine("which is... \n");
                Console.WriteLine("    " + Math.Ceiling((numPeople * 2) / 28) + " loaves of bread");
                Console.WriteLine("    " + Math.Ceiling((numPeople * 2) / 32) + " jars of peanut butter");
                Console.WriteLine("    " + Math.Ceiling((numPeople * 4) / 48) + " jars of jelly \n");

                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");

                response = Console.ReadLine();

            } while (response == "yes" || response == "y");

            Console.WriteLine("Goodbye");
        }
    }
}