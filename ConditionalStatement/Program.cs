/*
Author: Thomas Yi
Date: 1/28/2020
Description: Deliverable 2 - Conditionals
 */
using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Please enter your grade.");

            //use try and catch to prevent any value type other than Int.
            try
            {
                //gather data from user
                string input = Console.ReadLine();

                // convert a string into an int value
                int grade = int.Parse(input);

                // use if statement to limit value entered between 0-100, and display message
                if (grade > 100 || grade < 0)
                    Console.WriteLine("Value entered cannot be greater than 100 or smaller than 0. Please exit and try again");
                
                // If grade is between 90-100, display message
                if (grade >= 90 && grade <= 100)
                    Console.WriteLine("Your letter grade is: A");
                // If grade is between 80-90, display message
                else if (grade >= 80 && grade < 90)
                    Console.WriteLine("Your letter grade is: B");
                // If grade is between 70-80, display message
                else if (grade >= 70 && grade < 80)
                    Console.WriteLine("Your letter grade is: C");
                // If grade is between 60-70, display message
                else if (grade >= 60 && grade < 70)
                    // If grade below 60, display message
                    Console.WriteLine("Your letter grade is: D");
                else if (grade < 60 && grade >= 0)
                    Console.WriteLine("Your letter grade is: F");


            } // End of try
            catch
            {
                //display messages when user enters any other data type other than int
                Console.WriteLine("Please enter a int data type for your grade next time...");
                Console.WriteLine("Press any key to exit the program and try again...");
                // Pause the program and await the user to press a key to end the program
                Console.ReadKey(true);
            } // end of catch
        }
        }
}
