/*
Author: Khushbu Patel
Date: 1/30/2023
Description: C# Console App that askes user to pick an even or odd number
*/
using System;
using System.ComponentModel;

namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = 0;

                while (true)
                {
                    Console.Write("Enter an integer number between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }

                Console.Write("Specify the series type: Even or Odd: ");
                string series = Console.ReadLine();

                if (series == "Odd")
                {
                    Console.Write("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                    for (int i = 1; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (series == "Even")
                {
                    Console.Write("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                    for (int i = 0; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            catch
            {
                Console.WriteLine("Please enter an integar.");
            }
        }
    }
}