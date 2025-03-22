using System;
using System.Xml;

namespace Exercício_poo_3
{
    class Produto

    {
        string Nome;
        double Preco;
        int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void AdicionarEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                Quantidade += quantidade;
                Console.WriteLine($"{quantidade} unidades adicionadas ao estoque. ");
            }
            else
            {
                Console.WriteLine("A quantidade deve ser maior que zero. ");

            }
        }

        public void RemoverEstoque( int quantidade )
        {
            if ( quantidade > 0 && quantidade <= Quantidade)
            {
                Console.WriteLine($"{quantidade} unidades removidas do estoque. ");

            }
            else if (quantidade > Quantidade)
            {
                Console.WriteLine("Quantidade insuficiente no estoque. ");
            }
            else
            {
                Console.WriteLine("A quantidade deve ser maior que zero. ");
            }

        }
        public void ExibirDetalhes()
        {
            Console.WriteLine("\n--- Detalhes do Produto ---");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R${Preco:F2}");
            Console.WriteLine($"Quantidade em estoque: {Quantidade}");
        }







    }
}

