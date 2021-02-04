using System;

namespace butlerQ_Deliverable2_Iterative
{
    /*
    Author: Quinn Butler
    Date: 1/27/2021
    Comments: C# console application uses iterative/loop statements after receiving input to print all integers in loop
    */
    class Program
    {
        //Creating a function/method to save on not having to repeat console output
        static void ExitProgram()
        {
            Console.WriteLine("Please press any key to exit console.");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            /*
            PROGRAM #2: Based on what you have learned from the Iterative Statements example, write a C# Program Console Program with Iterative Statements that does the following: 
            1. Choose to write your program with only 1 of the 3 choices of Iterative Statements: While, For, or Do While (Just choose 1)
            2. Ask the user to enter an integer value between 1 and 100.
            3. Then, have the program display the following message the number of times the user has entered for the integer value: "You have entered #. This is the current integer value in the loop: #"
            EXAMPLE INPUT: 2
            EXAMPLE OUTPUT: 
            You have entered 2. This is the current integer value in the loop: 1
            You have entered 2. This is the current integer value in the loop: 2 
            */
            //For this case, I would want to use a for loop, create a counter integer variable to iterate in that loop, print its current value and adding 1 for each iteration until the count matches the input integer
            Console.WriteLine("Please enter an integer value between 1 and 100");
            //Create a try/catch block to validate input is an integer
            try
            {
                //Create string variable for user input and read input from console
                string inputUser = Console.ReadLine();
                //Parse input and create/set variable for integer variable
                int inputValue = int.Parse(inputUser);
                //Conditional for determining if input is between 1 and 100
                if (inputValue >= 1 & inputValue <= 100)
                {
                    //create integer count variable
                    int count;
                    //simple For loop for counting from 1 to input value, iterating +1 each cycle of loop
                    for (count = 1; count <= inputValue; count++)
                    {
                        //required output for each loop
                        Console.WriteLine("You have entered " + inputValue + ". This is the current integer value in the loop: " + count);
                    }
                    //Ask for user input to close console
                    ExitProgram();
                }
                else
                {
                    //Ask for user input to close console
                    Console.WriteLine("Please input a valid integer value between 1 and 100.");
                    ExitProgram();
                }
            }
            catch
            {
                //Ask for user input to close console
                Console.WriteLine("Please input a valid integer value between 1 and 100.");
                ExitProgram();
            }
        }
    }
}
