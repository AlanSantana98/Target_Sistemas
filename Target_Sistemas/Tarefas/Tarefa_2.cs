using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());
        int a = 0, b = 1, c = 0;

        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }

        if (c == num || num == 0)
            Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
    }
}
