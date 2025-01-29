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

            // Display fibbonacci series using a do-while loop
            Console.WriteLine("\nFibonacci Series");
            int firstNumber = 0, secondNumber = 1, nextNumber; //First 2 numbers
            Console.Write($"{firstNumber} {secondNumber} "); //display first 2 numbers
            int count = 2; //Count starts at 2
            // Loop to generate next 10 numbers in the series
            do
            {
                nextNumber = firstNumber + secondNumber; //Calc Next number
                Console.Write($"{nextNumber} "); //display next number
                firstNumber = secondNumber;
                secondNumber = nextNumber; //updates
                count++;
            } while (count > 10);    //loop until count = 10

            //Display favorite fruits in a collection using a foreach loop 
            //Create an array of fruits | datat structure preview
            string[] fruits = { "Apple", "Bannana", "Pear", "Strawberry" };

            Console.Writeline("\n");
            //Display Each Fruit using foreach loop
            Console.Writeline("your favorite fruits are :");
            //loop each fruit in array
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }
        }
    }
}
