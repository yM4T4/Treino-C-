using System;

class Decimal
{
    static void Main()
    {
        Console.WriteLine("Insira um número");
        double num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"O número com casa decimal é: {num:F2}");
    }
}