using System;
class Program
{
    static void Main()
    {
        bool keepGoing = true;
        Random rnd = new Random(); // Create a single instance of Random

        while (keepGoing)
        {
            // Display the menu
            Console.WriteLine("Welcome to Crimson Crust! Please select an option:");
            Console.WriteLine("1 - Display a plain, topping-less pizza slice (Triangle pattern)");
            Console.WriteLine("2 - Display a cheese pizza slice (Outlined pattern)");
            Console.WriteLine("3 - Display a pepperoni pizza slice (Random pepperoni)");
            Console.WriteLine("4 - Exit");
            Console.Write("Enter your choice: ");
            
            // Read user input and handle potential null value
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Input was null. Please try again.");
                continue; // Continue the loop to display the menu again
            }

            // Process user input
            switch (input)
            {
                case "1":
                    PlainPizza(rnd); // Call the PlainPizza method
                    break;

                case "2":
                    CheesePizza(rnd); // Call the CheesePizza method
                    break;

                case "3":
                    PepPizza(rnd); // Call the PepPizza method
                    break;

                case "4":
                    Console.WriteLine("Exiting... Thank you for visiting Crimson Crust!");
                    keepGoing = false; // Set keepGoing to false to break the loop
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
            
            Console.WriteLine(); // Add a blank line for better readability
        }
    }

    // Method to display a plain, topping-less pizza slice
    static void PlainPizza(Random rnd)
    {
        int numRows = rnd.Next(8, 13);
        Console.WriteLine($"Displaying a plain, topping-less pizza slice (Triangle pattern) with {numRows} rows:");

        for (int i = numRows; i > 0; i--) // Outer loop controls the number of rows
        {
            for (int j = 0; j < i; j++) // Inner loop controls the number of asterisks in each row
            {
                Console.Write("* ");
            }
            Console.WriteLine(); // Move to the next line after printing each row
        }
    }

    // Method to display a cheese pizza slice (outlined with asterisks and filled with hashtags)
    static void CheesePizza(Random rnd)
    {
        int numRows = rnd.Next(8, 13);
        Console.WriteLine($"Displaying a cheese pizza slice (Outlined pattern) with {numRows} rows:");

        for (int i = numRows; i > 0; i--) // Outer loop for the number of rows
        {
            for (int j = 0; j < i; j++) // Inner loop for characters in each row
            {
                if (j == 0 || j == i - 1 || i == numRows)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("# ");
                }
            }
            Console.WriteLine(); // Move to the next line after printing each row
        }
    }

    // Method to display a pepperoni pizza slice (randomly placed pepperoni)
    static void PepPizza(Random rnd)
    {
        int numRows = rnd.Next(8, 13);
        Console.WriteLine($"Displaying a pepperoni pizza slice with {numRows} rows (random pepperoni slices):");

        for (int i = numRows; i > 0; i--) // Outer loop for the number of rows
        {
            for (int j = 0; j < i; j++) // Inner loop for characters in each row
            {
                if (j == 0 || j == i - 1 || i == numRows)
                {
                    Console.Write("* ");
                }
                else
                {
                    // Randomly decide if a pepperoni slice should be placed
                    if (rnd.Next(0, 5) == 0) // 20% chance to place a pepperoni
                    {
                        Console.Write("[] ");
                    }
                    else
                    {
                        Console.Write("# ");
                    }
                }
            }
            Console.WriteLine(); // Move to the next line after printing each row
        }
    }
}