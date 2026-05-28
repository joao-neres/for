using System.Diagnostics.Contracts;

public static class ArrayAtv3
{
    public static void Executar()
    {


        int[] numeros = { 1, 2, 3, 4, 5 };
        int SomaTotal = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Insira o {i + 1}º número:");
            numeros[i] = int.Parse(Console.ReadLine()!);
            SomaTotal += numeros[i];
        }


        Console.Clear();
        Console.WriteLine($"-----Lista dos números-----");


        for (int listar = 0; listar < 5; listar++)
        {
            Console.WriteLine(numeros[listar]);
        }
        Console.WriteLine($"Resultado da soma: {SomaTotal}");
        Console.WriteLine("");
    }
}