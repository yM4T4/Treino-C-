using System;

class Inicial
{
    static void Main()
    {
        Console.Write("Insira um nome: ");
        char name1 = Console.ReadLine()[0];

        Console.Write("Insira outro nome: ");
        char name2 = Console.ReadLine()[0];

        Console.Write("Insira outro nome: ");
        char name3 = Console.ReadLine()[0];

        Console.Write($"As 3 primeiras letras dos nomes são: {name1} {name2} {name3}");   
    }
}