using System;

    class dolar
{
    static void Main()
    {
        Console.WriteLine("Digite o valor em reais: ");
        double real =  Convert.ToDouble(Console.ReadLine());
        double soma = real / 5.73;
        Console.WriteLine($"O valor em dolar é: {soma}");
    }
}