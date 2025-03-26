using System;

class Decimal
{
    static void Main()
    {
        Console.Write("Informe um número com virgula: ");
        double num = Convert.ToDouble(Console.ReadLine());
        int num2 = (int)Math.Round(num);

        Console.WriteLine($"O número inserido, aproximado, é: {num2}");
    }
}
       