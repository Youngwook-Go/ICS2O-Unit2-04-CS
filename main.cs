// Created by: Youngwook
// Created on: OCT 2022
//
// This function gets area of triangle

using System;

class Program
{
    public static void Main (string[] args)
    {
        int baseInfo;
        int heightInfo;

        Console.WriteLine("This program gets area of triangle.\n");
        Console.Write("Enter base of the triangle: "); baseInfo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height of the triangle: "); heightInfo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Area of triangle is : " + (baseInfo * heightInfo) / 2 );
    }
}