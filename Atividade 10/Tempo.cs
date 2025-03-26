using System;

class tempo
{
    static void Main()
    {
        Console.WriteLine("Escreva uma distancia em metros");
        double S = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva uma velocidade fixa em m/s");
        double V = Convert.ToDouble(Console.ReadLine());

        double T = S / V;

        Console.WriteLine($"O tempo necessario para percorrer todo o trajeto é: {T:F2}s");
            
    }
}