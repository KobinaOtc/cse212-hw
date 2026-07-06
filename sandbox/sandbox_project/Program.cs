using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        // Fixed arrays example.
        var numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        var altNumbers = new [] {1, 2, 3};

        // Lists example.
        var dynamicNumbers = new List<int>();
        dynamicNumbers.Add(1);
        dynamicNumbers.Add(2);
        dynamicNumbers.Add(3);

        var altDynamicNumbers = new List<int> {1, 2, 3};


        Console.WriteLine("Hello Sandbox World!");
    }
}