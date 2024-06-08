﻿using System;

Console.Write("Enter the first range: ");
short firstArgument = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter the first range: ");
short lastArgument = Convert.ToInt16(Console.ReadLine());

for(int i = 1; i <= 9; i++)
{
    for(int j = firstArgument; j <= lastArgument; j++)
    {
        Console.WriteLine($"{j}*{i}={j*i}");
    }
    Console.WriteLine();
}