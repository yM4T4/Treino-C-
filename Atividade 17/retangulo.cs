using System;

class Retangulo
{
    static void Main()
    {
        Console.WriteLine("Escreva a altura");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva a Largura");
        double L = Convert.ToDouble(Console.ReadLine());

        double soma = L * h;
        Console.Write($"A área do retangulo é: {soma}");
            
    }
}