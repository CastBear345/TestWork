using New_Project;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var book1 = new Book();
        book1.Id = 1;
        book1.Title = "Прикючения Марка";
        book1.Price = 100;

        var book2 = new Book();
        book2.Id = 2;
        book2.Title = "Прикючения Марка II";
        book2.Price = 100;

        var bookList = new List<Book>() { book1, book2};

        foreach (var book in bookList)
        {
            Console.WriteLine(book.Title);
        }
    }
}