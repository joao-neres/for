public static class ArrayAtv4
{
    public static void Executar()
    {

        int[] numeros = { 1, 2, 3, 4 };
        int Media = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Insira o {i + 1}º número:");
            numeros[i] = int.Parse(Console.ReadLine()!);
            Media += numeros[i];
        }


        Console.Clear();


        Console.WriteLine($"A média final é de: {Media / 4}");
        Console.WriteLine("");
    }
}