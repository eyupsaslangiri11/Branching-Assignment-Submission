using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greets the customer with an introductory message about the service
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Solicits and records the weight of the customer's package
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Conducts a weight check against the maximum shipping threshold
            if (weight > 50)
            {
                // Notifies customer of weight-based shipping restriction
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exits application when weight limit is exceeded
            }

            // Acquires the width measurement from the customer
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            // Acquires the height measurement from the customer
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            // Acquires the length measurement from the customer
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Performs a dimensional check to ensure package is within size limits
            if (width + height + length > 50)
            {
                // Advises customer that package dimensions exceed shipping capacity
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Terminates program when size limit is exceeded
            }

            // Executes the shipping cost calculation algorithm
            float quote = (height * width * length * weight) / 100;

            // Presents the shipping cost estimate to the customer
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Maintains the console window until user acknowledgment
            Console.ReadKey();
        }
    }
}