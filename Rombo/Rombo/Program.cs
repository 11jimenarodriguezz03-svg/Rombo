using System;

class Program
{
    static void Main()
    {
        string? input;

        do
        {
            Console.WriteLine("Rhombus Printer. Type 'exit' at any time to quit.");
            Console.Write("Enter the size of the rhombus: ");

            input = Console.ReadLine();

            if (input == null)
                continue;

            if (input.ToLower() == "exit")
                break;

            if (!int.TryParse(input, out int n) || n <= 0 || n % 2 == 0)
            {
                Console.WriteLine("Invalid value. Enter a positive odd integer.\n");
                continue;
            }

            int mid = n / 2;

            for (int i = 0; i <= mid; i++)
            {
                for (int s = 0; s < mid - i; s++)
                    Console.Write(" ");

                Console.Write("#");

                if (i > 0)
                {
                    for (int s = 0; s < 2 * i - 1; s++)
                        Console.Write(" ");
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            for (int i = mid - 1; i >= 0; i--)
            {
                for (int s = 0; s < mid - i; s++)
                    Console.Write(" ");

                Console.Write("#");

                if (i > 0)
                {
                    for (int s = 0; s < 2 * i - 1; s++)
                        Console.Write(" ");
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

        } while (true);

        Console.WriteLine("Program finished.");
    }
}
