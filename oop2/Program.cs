using System;
using System.Text.RegularExpressions; 

class Program
{
    static bool ValidateLogin(string login)
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";

        Regex regex = new Regex(pattern);

        return regex.IsMatch(login);
    }

    static void Main()
    {
        string[] testLogins = { "User1", "a1", "1user", "veryLongLogin123", "usr@1", "A" };

        foreach (var login in testLogins)
        {
            Console.WriteLine($"Логін '{login}': {ValidateLogin(login)}");
        }
    }
}