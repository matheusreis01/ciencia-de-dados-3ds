using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public double Desconto { get; set; }

    public double CalcularPrecoFinal()
    {
        return Preco - (Preco * Desconto / 100);
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto
        {
            Nome = "Fone de ouvido",
            Preco = 200,
            Desconto = 25 // Desconto alterado para teste
        };

        // Linha adicionada para exibir o preço inicial com 2 casas decimais
        Console.WriteLine($"Preço inicial de {produto.Nome}: R$ {produto.Preco:F2}");
        Console.WriteLine($"Preço final de {produto.Nome}: R$ {produto.CalcularPrecoFinal():F2}");
    }
}
