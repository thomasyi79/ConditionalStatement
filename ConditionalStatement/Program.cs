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
            // Ask the user estimated grade input
            Console.WriteLine("What grade do you think you will get in ISM 4300?");

            /* use the try catch block to validate user input
                if the user provides bad input, the catch block will
                handle the error and a message will be displayed.
            */
            try
            {
                // this variable will handle the input
                string input = Console.ReadLine();
                // converting integer input to a character
                int grade = int.Parse(input);
                // if statement for to show the letter grade: A
                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("Your letter grade is: A.");
                }
                else if (grade >= 80 && grade <= 89)
                {
                    // if statement for to show the letter grade: B
                    Console.WriteLine("Your letter grade is: B.");
                }
                else if (grade >= 70 && grade <= 79)
                {
                    // if statement for to show the letter grade: C
                    Console.WriteLine("Your letter grade is: C.");
                }
                else if (grade >= 60 && grade <= 69)
                {
                    // if statement for to show the letter grade: D
                    Console.WriteLine("Your letter grade is: D.");
                }
                else
                {
                    // if statement for to show the letter grade: F
                    Console.WriteLine("Your letter grade is: F.");
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please enter an integer to continue...");
                Console.WriteLine("---OR---");
                Console.WriteLine("Press any button to exit...");
            } // end of catch 
        } // end of string
    }
}
