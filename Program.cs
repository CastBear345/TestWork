using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите название текстового файла (без расширения):");
        string fileName = Console.ReadLine();

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string filePath = Path.Combine(desktopPath, $"{fileName}.txt");

        if (File.Exists(filePath))
        {
            Console.WriteLine($"Файл с именем {fileName}.txt уже существует на рабочем столе. Выберите другое имя.");
            return;
        }

        Console.WriteLine("Вы вводите строки, они будут записаны в файл. Для завершения введите 'exit' и нажмите Enter.");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            Console.WriteLine("Введите строку для записи в файл (введите 'exit' для завершения): ");
            while (true)
            {
                string input = Console.ReadLine();
                writer.WriteLine(input);
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
            }
        }

        Console.WriteLine();
        Console.Write("Вы уверены, что хотите создать файл? (Нажмите Enter для подтверждения)");
        ConsoleKeyInfo confirmKey = Console.ReadKey();
        Console.WriteLine();

        if (Console.KeyAvailable && confirmKey.Key == ConsoleKey.Escape)
        {
            Console.WriteLine("Отмена создания файла.");
            return;
        }

        Console.WriteLine($"Запись в файл {filePath} завершена.");
    }
}