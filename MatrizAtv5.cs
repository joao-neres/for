public static class MatrizAtv5
{
    public static void Executar()
    {
        string[] nomes = new string[2];
        double[,] notas = new double[2, 4];

        for (int coluna = 0; coluna < 2; coluna++)
        {
            Console.Write($"Digite o {coluna + 1}º nome: ");
            nomes[coluna] = Console.ReadLine()!;
        }


        for (int linha = 0; linha < 2; linha++)
        {
            double divisor = 0;
            double soma = 0;


            for (int coluna = 0; coluna < 4; coluna++)
            {
                Console.Write($"Digite a {coluna + 1}º nota do {nomes[linha]}: ");
                notas[linha, coluna] = double.Parse(Console.ReadLine()!);
                soma += notas[linha, coluna];
                divisor++;

                if (coluna == 3)
                {
                    double media = soma / divisor;
                    Console.WriteLine($"O aluno {nomes[linha]} tem média de {media}");
                }
            }
        }
    }
}