using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_poo_3
{
    internal class class1
    {
        class Program
        {
            static void Main()
            {
               
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o preço do produto: {F2} ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade inicial no estoque: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nome, preco, quantidade);

                int opcao;
                do
                {
                    Console.WriteLine("\nEscolha uma opção:");
                    Console.WriteLine("1 - Adicionar ao estoque");
                    Console.WriteLine("2 - Remover do estoque");
                    Console.WriteLine("3 - Exibir detalhes do produto");
                    Console.WriteLine("4 - Sair");
                    Console.Write("Opção: ");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite a quantidade a ser adicionada: ");
                            int qtdAdicionar = int.Parse(Console.ReadLine());
                            produto.AdicionarEstoque(qtdAdicionar);
                            break;

                        case 2:
                            Console.Write("Digite a quantidade a ser removida: ");
                            int qtdRemover = int.Parse(Console.ReadLine());
                            produto.RemoverEstoque(qtdRemover);
                            break;

                        case 3:
                            produto.ExibirDetalhes();
                            break;

                        case 4:
                            Console.WriteLine("Saindo do programa...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida! Tente novamente.");
                            break;
                    }
                } while (opcao != 4);
            }
        }
    }
}
