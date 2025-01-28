// Author:      Gauge Garcia
// Course:      Comp-003A
// Faculty:     Johnathan Cruz
// Purpose:     Demonstrate iterative statements in C#

namespace COMP003A.LectureActivity3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interactive Statements Demo!\n");

            //Prompt for Posiitive Integer
            int num;
            Console.Write("Enter a positive integrer to generate its multiplication table: ");
            num = int.Parse(Console.ReadLine());

            //Generate Multiplication Table using For Loop
            Console.WriteLine($"Multipllication Table for {num}:");

            for (int i = 1; i <= 10; i++)
            {
                // display the multiplication table
                Console.WriteLine($"{i} x {num}={i * num}");
            }

            //Display the table in reverse using while loop
            Console.WriteLine("\nReversed Multiplication Table:");
            int reverse = 10;
            //Loop to generate reverse
            while (reverse > 0)
            {
                //Display
                Console.WriteLine($"{reverse} x {num}={reverse * num}");
                //Decrement Reverse
                reverse--;
            }


        }
    }
}
