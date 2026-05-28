public static class ArrayAtv2
{
    public static void Executar()
    {

        int[] contador = new int[6];

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Insira o {i + 1}º número:");
            contador[i] = int.Parse(Console.ReadLine()!);
        }

        Console.Clear();
        Console.WriteLine($"-----Lista dos números-----");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"O {i + 1}º número é {contador[i]}");
            Console.WriteLine("");
        }
    }
}