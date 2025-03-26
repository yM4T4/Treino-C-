using System;

    class aritmetica
{
    static void Main()
    {
        Console.WriteLine("Informe 2 números para realizar uma média artmética: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        double soma = (num1 + num2) / 2;

        Console.Write($"O valor da média aritmética é: {soma}");


       
    }
}