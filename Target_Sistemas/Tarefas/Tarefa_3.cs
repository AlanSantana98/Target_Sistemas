using System;
using System.Linq;
using System.Text.Json;
using System.IO;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("faturamento.json"); // Substitua pelo caminho do JSON
        var faturamento = JsonSerializer.Deserialize<decimal[]>(json);
        var diasValidos = faturamento.Where(v => v > 0).ToArray();

        decimal menor = diasValidos.Min();
        decimal maior = diasValidos.Max();
        decimal media = diasValidos.Average();
        int diasAcimaMedia = diasValidos.Count(v => v > media);

        Console.WriteLine($"Menor valor: {menor}");
        Console.WriteLine($"Maior valor: {maior}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
    }
}
