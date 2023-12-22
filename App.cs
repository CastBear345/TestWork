using System;

public class App
{
    private string systemPassword;

    public App(string password)
    {
        systemPassword = password;
    }

    public void Startup()
    {
        Console.WriteLine("Введите ваше имя:");
        string username = Console.ReadLine();

        Console.WriteLine("Введите ваш пароль:");
        string password = Console.ReadLine();

        User? newUser = CreateUser(username, password);

        HelloUser(newUser);
    }

    private User? CreateUser(string username, string password)
    {
        if (password == systemPassword)
        {
            User newUser = new User(username, password);
            return newUser;
        }
        else
        {
            Console.WriteLine("Неверный пароль. Вход в систему невозможен.");
            return null;
        }
    }

    private void HelloUser(User? user)
    {
        if (user != null)
        {
            Console.WriteLine($"Привет, {user.Value.Username}!");
        }
        else
        {
            Console.WriteLine("Вам не удалось войти в систему.");
        }
    }
}