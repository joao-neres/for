public static class MatrizAtv3
{
    public static void Executar()
    {
        int[,] numeros = new int[3, 2];
        int SomaTotal = 0;


        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write("Digite seu número:");
                numeros[linha, coluna] = int.Parse(Console.ReadLine()!);
                SomaTotal += numeros[linha, coluna];
            }
        }


        Console.WriteLine();
        Console.Clear();


        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write(numeros[linha, coluna] + "\t");
            }
            Console.WriteLine("");
            Console.WriteLine($"A soma total dos números é de: {SomaTotal}");
        }
    }
}