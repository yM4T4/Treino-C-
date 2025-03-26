using System;
using System.Security.Cryptography.X509Certificates;

class Maiusculo
{
    static void Main()
    {
        Console.WriteLine("Escreva seu nome em letra minuscula");
        string pal = Console.ReadLine();
        string palM = pal.ToUpper();

        Console.Write($"Seu nome em maiusculo: {palM}");
    }
}