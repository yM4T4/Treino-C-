using System;

class Circulo
{
    static void Main()
    {
        Console.WriteLine("Informe o raio do seu circulo");
        double raio = Convert.ToDouble(Console.ReadLine());
        double soma = Math.Pow(raio, 2) * 3.1415;
        Console.WriteLine($"A area do seu circulo é: {soma}");

           
    }
}