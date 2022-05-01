// Created by: Joanne Santhosh
// Created on: Apr 2022
//
// This program calculates the volume of a triangle

using System;

class Program
{
     public static void Main(string[] args)
    {
        // This program calculates the volume of a triangle
        int lengthOfTriangle;
        int widthOfTriangle;
        int heightOfTriangle;
        Console.WriteLine("This program calculates the volume of a triangle");
        Console.WriteLine("");

        Console.WriteLine("Enter the length of the triangle.");
        lengthOfTriangle = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter the width of the triangle. ");
        widthOfTriangle = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter the height of the triangle.");
        heightOfTriangle = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("");
        Console.WriteLine("Area is: " + (lengthOfTriangle * widthOfTriangle * heightOfTriangle / 3) + " cm³ ");

        Console.WriteLine("\nDone.");
    }
}