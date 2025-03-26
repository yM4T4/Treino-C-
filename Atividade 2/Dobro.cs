using System;

class Dobro
{
    static void Main()
    {
        Console.WriteLine("Escreva um número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 * 2;
        Console.WriteLine($"O dobro do seu número é: {soma}");
    }
}