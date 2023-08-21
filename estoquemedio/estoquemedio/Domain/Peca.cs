using System;

class Peca
{
    // Propriedades da peça
    public string Nome { get; set; }
    public int QuantidadeMinima { get; set; }
    public int QuantidadeMaxima { get; set; }

    // Construtor da classe
    public Peca(string nome, int quantidadeMinima, int quantidadeMaxima)
    {
        Nome = nome;
        QuantidadeMinima = quantidadeMinima;
        QuantidadeMaxima = quantidadeMaxima;
    }

    // Método para calcular o estoque médio
    public double CalcularEstoqueMedio()
    {
        return (QuantidadeMinima + QuantidadeMaxima) / 2.0;
    }
}

