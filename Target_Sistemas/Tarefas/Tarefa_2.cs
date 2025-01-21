using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um n�mero: ");
        int num = int.Parse(Console.ReadLine());
        int a = 0, b = 1, c = 0;

        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }

        if (c == num || num == 0)
            Console.WriteLine($"{num} pertence � sequ�ncia de Fibonacci.");
        else
            Console.WriteLine($"{num} n�o pertence � sequ�ncia de Fibonacci.");
    }
}
