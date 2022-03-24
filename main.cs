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
        string street_name;
        int street_number;

        Console.WriteLine("This program gets a user's address.");
        Console.WriteLine("");

        Console.Write("Enter your street name: ");
        street_name = Console.ReadLine();
        Console.Write("Enter your street number: ");
        street_number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your address is: " + street_name + ", house " + street_number + ".");

        Console.WriteLine("\nDone.");
    }
}