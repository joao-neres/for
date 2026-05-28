public static class MatrizAtv1
{
    public static void Executar()
    {
        string[,] nomes = new string[2, 2];

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write("Digite seu número:");
                nomes[linha, coluna] = Console.ReadLine()!;
            }
        }

        Console.WriteLine();

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write(nomes[linha, coluna] + "\t");
            }
            Console.WriteLine("");
        }
    }
}