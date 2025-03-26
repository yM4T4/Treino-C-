using System;

class Horas
{
    static void Main()
    {
        Console.WriteLine("Escreva as horas");
        double hour = Convert.ToDouble(Console.ReadLine());

        double minute = hour * 60;
        double second = minute * 60;

        Console.Write($"O valor das horas em minutos e segundos é, respectivamente: {minute}m e {second}s");
    }
}