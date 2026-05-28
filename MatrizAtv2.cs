public static class MatrizAtv2
{
    public static void Executar()
    {
        int[,] numeros = new int[3, 2];

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write("Digite seu número:");
                numeros[linha, coluna] = int.Parse(Console.ReadLine()!);
            }
        }

        Console.WriteLine();

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write(numeros[linha, coluna] + "\t");
            }
            Console.WriteLine("");
        }
    }
}