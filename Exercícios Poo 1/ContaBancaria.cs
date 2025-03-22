using System;
namespace Exercícios_Poo_2;
class ContaBancaria
{
    public string NumeroConta { get; private set; }
    public string Titular { get; private set; }
    private double Saldo;

   
    public ContaBancaria(string numeroConta, string titular, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = saldoInicial;
    }
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser positivo.");
        }
    }

    
    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido para saque.");
        }
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R$ {Saldo}");
    }
}
