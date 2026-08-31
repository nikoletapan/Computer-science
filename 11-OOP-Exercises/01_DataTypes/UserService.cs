using System;

public static class UserService
{
    public static void GreetUser(string name)
    {
        Console.WriteLine($"Добре дошли, {name}!");
    }

    public static bool ValidateUser(string username, string password)
    {
        return !string.IsNullOrEmpty(username) &&
               !string.IsNullOrEmpty(password) &&
               password.Length >= 6;
    }
}