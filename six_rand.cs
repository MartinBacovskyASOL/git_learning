using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello!");
        Random rnd = new Random();
        int number = rnd.Next(1, 7); // 1 to 6 inclusive
        Console.WriteLine("Your random number is: " + number);
    }
}
