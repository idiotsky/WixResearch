using System;
using System.IO;

namespace HelloWorld;

internal static class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World.");
        Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        Console.WriteLine(Environment.CurrentDirectory);
        if (File.Exists("CustomAction.txt"))
        {
            Console.WriteLine(File.ReadAllText("CustomAction.txt"));
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}
