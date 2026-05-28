public static class MatrizAtv4
{
    public static void Executar()
    {
        int[,] numeros = new int[2, 2];
        int media = 0;
        double divisor = 0;


        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write("Digite seu número:");
                numeros[linha, coluna] = int.Parse(Console.ReadLine()!);
                media += numeros[linha, coluna];
                divisor++;
            }
        }


        Console.WriteLine();
        Console.Clear();


        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write(numeros[linha, coluna] + "\t");
            }
            Console.WriteLine("");
            Console.WriteLine($"A soma total dos números é de: {media / divisor}");
        }
    }
}