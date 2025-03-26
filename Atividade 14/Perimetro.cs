using System;

class Perimetro
{
    static void Main()
    {
        Console.WriteLine("Informe o lado do quadrado: ");
        double num = Convert.ToDouble(Console.ReadLine());

        double soma = 4 * num;

        Console.WriteLine($"O perímetro do quadrado de lado {num} é {soma}");

            
    }
}