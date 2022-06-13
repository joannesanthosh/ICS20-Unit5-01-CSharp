// Created by: Joanne Santhosh
// Created on: May 2022
//
// This program guesses the number from 1 - 6

using System;

class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        int number = random.Next(1, 6);
        int userGuess;

        // input
        Console.WriteLine("Guess a number between 1-6");
        userGuess = int.Parse(Console.ReadLine());

        // process
        if (userGuess == number)
            Console.WriteLine("Correct answer!");
        else
            Console.WriteLine("Incorrect, try again!");
        Console.WriteLine("\nDone.");
    }
}