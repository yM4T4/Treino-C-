using System;

class Cubo
{
    static void Main()
    {
        Console.Write("Informe um número: ");

        double num = Convert.ToDouble(Console.ReadLine());

        double quadrado = Math.Pow(num, 2);
        double cubo = Math.Pow(num, 3);

        Console.Write($"O valor de {num} ao quadrado e ao cubo é, respectivamente: {quadrado} e {cubo}");
    }
}