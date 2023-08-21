using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe os detalhes da peça:");
        Console.Write("Nome da peça: ");
        string nome = Console.ReadLine();

        Console.Write("Quantidade mínima: ");
        int quantidadeMinima = int.Parse(Console.ReadLine());

        Console.Write("Quantidade máxima: ");
        int quantidadeMaxima = int.Parse(Console.ReadLine());

        Peca peca = new Peca(nome, quantidadeMinima, quantidadeMaxima);

        double estoqueMedio = peca.CalcularEstoqueMedio();

        Console.WriteLine($"Estoque médio da peça {peca.Nome}: {estoqueMedio}");

        // Aguarda o usuário pressionar Enter para encerrar o programa
        Console.ReadLine();
    }
}

