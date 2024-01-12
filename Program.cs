using New_Project;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Nebelung nebelungCat = new Nebelung();

        Koshka<Nebelung> myCat = new Koshka<Nebelung>(nebelungCat);

        Console.WriteLine($"Cat breed: {myCat.Poroda.GetType().Name}");
        Console.WriteLine($"Fur length: {myCat.Poroda.Length}");
        Console.WriteLine($"Fur color: {myCat.Poroda.Color}");
        Console.WriteLine($"Average weight: {myCat.Poroda.AverageWeight} kg");
        Console.WriteLine($"Price: ${myCat.Poroda.Price}");
    }
}