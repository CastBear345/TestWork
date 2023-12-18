using GG;
using System;
using System.Collections.Generic;

partial class program
{
    static void Main(string[] args)
    {
        string hello;

        hello = "Hello World!";

        // ????? ????????
        string world = "hello";

        const int kek = 0;

        string input = Console.ReadLine();

        Console.WriteLine(input);

        string reference;

        int value;

        reference = null;

        reference = Console.ReadLine();

        if (reference == "Марк")
        {
            Console.WriteLine("Пока Марк");
        }
        else if (reference == "ТОЧНО не Марк")
        {

        }
        else
        {

        }

        switch (input)
        {
            case "1":
                break;

            case "2":
                break;

            default:
                break;

        }

        string input2 = (Console.ReadLine() == "GG") ? "GG" : "GGG";

        //while(true) { }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("test");
        }

        int a = 1;
        while (a <= 100)
        {
            Console.WriteLine(a);
            a++;
        }

        do
        {
            Console.WriteLine("hello");
        } while (a == 1000);

        int[] array = new int[5] { 1, 2, 3, 4, 5 };

        foreach (int i in array)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(array.Length);

        DateTime date = DateTime.Now;

        date.AddYears(1);

        string concat = input + " " + date;

        string name = $"{input}";

        int y = 0;
        int x = 1;
        try
        {
            int z = x / y;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        PublicClass publicClass = new PublicClass();

        List<PublicStruct> list = new List<PublicStruct>();

        
    }
}