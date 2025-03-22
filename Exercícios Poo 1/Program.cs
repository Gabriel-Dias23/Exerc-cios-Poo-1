using Exercícios_Poo_2;
class Program
{
    static void Main()
    {
        // Criando uma conta bancária
        Console.Write("Digite o número da conta: ");
        string numeroConta = Console.ReadLine();

        Console.Write("Digite o nome do titular: ");
        string titular = Console.ReadLine();

        Console.Write("Digite o saldo inicial: ");
        double saldoInicial = double.Parse(Console.ReadLine());

        ContaBancaria conta = new ContaBancaria(numeroConta, titular, saldoInicial);

        int opcao;
        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Exibir Saldo");
            Console.WriteLine("4 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o valor a depositar: ");
                    double deposito = double.Parse(Console.ReadLine());
                    conta.Depositar(deposito);
                    break;
                case 2:
                    Console.Write("Digite o valor a sacar: ");
                    double saque = double.Parse(Console.ReadLine());
                    conta.Sacar(saque);
                    break;
                case 3:
                    conta.ExibirSaldo();
                    break;
                case 4:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 0);
    }
}
