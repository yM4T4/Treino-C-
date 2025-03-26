using System;
using System.Runtime.Serialization;

class Cm
{
    static void Main()
    {
        Console.WriteLine("Escreva o valor em metros: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 * 100;
      Console.WriteLine($"O valor em cm é: {soma}");
            
    }
}
