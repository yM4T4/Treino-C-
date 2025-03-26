using System;

class Somatorio
{
    static void Main()

    {
        Console.WriteLine("Digite um número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 + num2;

        Console.WriteLine($"A soma dos números é: {soma}");
    }
}