// Aqui eu não compreendi muito bem oque o senhor quer, como o já foi solicitado anteriormente a soma de dois números,
// imaginei que quer algo mais complexo
//nada aqui foi feito por IA, usei como base apenas documentações e fóruns
using System;

class Compras
{
    static void Main()
    {
        string[] produtos = { "Arroz", "Feijão", "Carne", "Banana", "Leite" };
        double[] valor = { 15, 20, 50, 10, 6 };

        Console.WriteLine("Lista de produtos disponíveis:");
        for (int x = 0; x < produtos.Length; x++)
        {
            Console.WriteLine($"{x + 1} - {produtos[x]}: R$ {valor[x]:F2}");

        }
        Console.WriteLine("Escolha o número de um produto: ");
        int produto1 = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("Escolha o número de mais um produto: ");
        int produto2 = Convert.ToInt32(Console.ReadLine()) - 1;

        if (produto1 < 0 || produto1 >= produtos.Length || produto2 < 0 || produto2 >= produtos.Length)

        {
            Console.WriteLine("Escolha invalida, digite um número valido");
        }
        else
        {
            double soma = valor[produto1] + valor[produto2];
            Console.WriteLine($"O valor de seus produtos é R${soma:F2}");
        }
    }
}
