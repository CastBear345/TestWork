using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите свой возраст: ");
        int age = int.Parse(Console.ReadLine());

        if (age <= 20)
        {
            throw new AgeException();
        }
        else
        {
            Console.WriteLine($"Ваш возраст: {age}");
        }
    }
}