using System;

class Temperatura
{
    static void Main()
    {
        Console.WriteLine("Escreva uma temperatura em Celsius: ");
        double temp = Convert.ToDouble(Console.ReadLine());
        double soma = (temp * 9 / 5) + 32;

        Console.WriteLine($"A temperatura em Fahrenheit é: {soma}");

    }
}