using System;

class ConcatenarTexto
{
    static void Main()
    {
        Console.WriteLine("Informe o primeiro texto: ");
        string text1 = Console.ReadLine();

        Console.WriteLine("Informe o segundo texto: ");
        string text2 = Console.ReadLine();

        string juncao = text1 + " " + text2;

        Console.Write($"Texto junto é: {juncao}");
    }
}
