using System;

namespace Class02Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("RealCalculator");
            #region Exercises
            // Task 01
            /*Create new console application “RealCalculator”
            that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.*/

            //Console.WriteLine("Enter the First number: ");
            //bool numberOne = int.TryParse(Console.ReadLine(), out int num01);
            //Console.WriteLine("Enter your Second number: ");
            //bool numberTwo = int.TryParse(Console.ReadLine(), out int num02);
            //Console.WriteLine("Enter your operation: ");
            //bool operationFinal = char.TryParse(Console.ReadLine(), out char operation);
            //int result;

            //if (numberOne || numberTwo || operationFinal)
            //{
            //    if (operation == '+')
            //    {
            //        int addition = num01 + num02;
            //        result = addition;
            //        Console.WriteLine(num01 + " + " + num02 + " = " + result);
            //        Console.WriteLine("The result is: " + result);
            //    }
            //    else if (operation == '-')
            //    {
            //        int subtraction = num01 - num02;
            //        result = subtraction;
            //        Console.WriteLine(num01 + " - " + num02 + " = " + result);
            //        Console.WriteLine("The result is: " + result);
            //    }
            //    else if (operation == '*')
            //    {
            //        int multiplication = num01 * num02;
            //        result = multiplication;
            //        Console.WriteLine(num01 + " * " + num02 + " = " + result);
            //        Console.WriteLine("The result is: " + result);
            //    }
            //    else if (operation == '/')
            //    {
            //        int division = num01 / num02;
            //        result = division;
            //        Console.WriteLine(num01 + " / " + num02 + " = " + result);
            //        Console.WriteLine("The result is: " + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine(value: "No such operator");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Try Again");
            //}

            Console.WriteLine("====================");

            // Task 02
            // Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            Console.WriteLine("AverageNumber");

            //Console.WriteLine("Enter the first number: ");
            //bool firstNum = int.TryParse(Console.ReadLine(), out int a);
            //Console.WriteLine("Enter the second number: ");
            //bool secoundNum = int.TryParse(Console.ReadLine(), out int b);
            //Console.WriteLine("Enter the third number: ");
            //bool thirdNum = int.TryParse(Console.ReadLine(), out int c);
            //Console.WriteLine("Enter the fourth number: ");
            //bool fourthNum = int.TryParse(Console.ReadLine(), out int d);

            //if (firstNum || secoundNum || thirdNum || fourthNum)
            //{
            //    int result = (a + b + c + d) / 4;
            //    Console.WriteLine("The average of:" + a + "," + b + "," + c + "," + d + " is:" + result);
            //}
            //else
            //{
            //    Console.WriteLine(value: "Enter valid number");
            //}

            Console.WriteLine("====================");

            // Task 03
            // Create new console application “SwapNumbers”.
            /* Input 2 numbers from the console and then swap the values of the variables so that the first
             variable has the second value and the second variable the first value. Please find example below:*/
            Console.WriteLine("SwapNumbers");

            //Console.WriteLine("Input the First Number: ");
            //bool ifSuccessInputUserOne = int.TryParse(Console.ReadLine(), out int inputNumberOne);
            //Console.WriteLine("Input the Second Number: ");
            //bool ifSuccessInputUserTwo = int.TryParse(Console.ReadLine(), out int inputNumberTwo);


            //if (ifSuccessInputUserOne || ifSuccessInputUserTwo)
            //{

            //    int result01 = inputNumberOne;
            //    inputNumberOne = inputNumberTwo;
            //    inputNumberTwo = result01;

            //    Console.WriteLine("First input number after swapping: " + inputNumberOne);
            //    Console.WriteLine("Second input number after swapping: " + inputNumberTwo);
            //}
            //else
            //{
            //    Console.WriteLine(value: "Enter a valid number");
            //}

            // Task 04
            // Write a program, where for a given number entered via the keyboard, it will print:
            Console.WriteLine("Task 4 - divisible by 3 and 5 ");

            //Console.WriteLine("Enter your first number: ");
            //bool inputNum01 = int.TryParse(Console.ReadLine(), out int divisibleByThree);
            //Console.WriteLine("Enter your second number: ");
            //bool inputNum02 = int.TryParse(Console.ReadLine(), out int divisibleByFive);

            //if (inputNum01 && inputNum02)
            //{
            //    if (divisibleByThree % 3 == 0 && divisibleByFive % 5 == 0)
            //    {
            //        Console.WriteLine(value: "Tik-Tak");
            //    }
            //    else if (divisibleByThree % 3 == 0)
            //    {
            //        Console.WriteLine(value: "Tik");
            //    }
            //    else if (divisibleByFive % 5 == 0)
            //    {
            //        Console.WriteLine(value: "Tak");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(value: "Bad number");
            //}

            Console.WriteLine("========================");
            #endregion

            Console.ReadLine();
        }
    }
}
