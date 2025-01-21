using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe uma string: ");
        string input = Console.ReadLine();
        string inverted = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            inverted += input[i];
        }

        Console.WriteLine($"String invertida: {inverted}");
    }
}
