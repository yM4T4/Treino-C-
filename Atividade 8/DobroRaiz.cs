using System;

class Triplo
{
    static void Main()
    {
        Console.WriteLine("Escreva um número");
        double num = Convert.ToDouble(Console.ReadLine());

        double dobro = num * 2;
        double triplo = num * 3;
        double raiz = Math.Sqrt(num);

        Console.WriteLine($"O dobro, triplo e a raiz quadrada de seu número são, respectivamente: {dobro}, {triplo}, {raiz:F3}");
    }
    
        
}