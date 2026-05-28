public static class ArrayAtv6
{
    public static void Executar()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        int suporteNumeros;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Insira o {i + 1}º número:");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }
        Console.Clear();
        for (int verificar = 1; verificar <= 5; verificar++)
        {
            for (int ns = 0; ns < 4; ns++)
            {
                if (numeros[ns] > numeros[ns + 1])
                {
                    suporteNumeros = numeros[ns + 1];
                    numeros[ns] = suporteNumeros;
                }
            }
        }
        for (int listar = 0; listar <= 4; listar++)
        {
            Console.WriteLine(numeros[listar]);
        }
    }

}