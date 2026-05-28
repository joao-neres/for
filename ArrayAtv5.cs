public static class ArrayAtv5
{
    public static void Executar()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        int maior = numeros[0];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Insira o {i + 1}º número:");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }
        for (int ns = 0; ns < 4; ns++)
        {
            if (maior < numeros[ns + 1])
            {
                maior = numeros[ns + 1];
            }
        }


        Console.Clear();

        Console.WriteLine($"O maior número digitado foi: {maior}");
        Console.WriteLine("");
    }
}