public static class ArrayAtv1
{
    public static void Executar()
    {

        string[] NomeAlunos = { "", "", "", "", "" };
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Insira o nome do {i + 1}º aluno:");
            NomeAlunos[i] = (Console.ReadLine()!);
        }

        Console.Clear();
        Console.WriteLine($"-----Nome dos alunos-----");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"O nome do {i + 1}º aluno é {NomeAlunos[i]}");
        }
    }
}