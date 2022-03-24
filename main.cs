// Created by: Venika Sem
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string streetName;
        int streetNumber;

        Console.WriteLine("This program gets a user's address.");
        Console.WriteLine("");

        Console.Write("Enter your street number: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your street name: ");
        streetName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Your address is: " + streetNumber + ", " + streetName + ".");

        Console.WriteLine("\nDone.");
    }
}