using System;
using System.Globalization;

namespace exercicíos_poo_1;

class Aluno
{
    public string RA { get; private set; }
    public string nome { get; private set; }
    private double NotaProva;
    private double NotaTrabalho;
    private double NotaFinal;


    public void ReceberDados()
    {
        Console.WriteLine(" Digite o RA do Aluno: ");
        RA = Console.ReadLine();

        Console.WriteLine(" Digite o nome do Aluno: ");
        nome = Console.ReadLine();

        Console.WriteLine(" Digite a nota do Aluno: ");
        NotaProva = double.Parse(Console.ReadLine());

        Console.WriteLine(" Digite o Nota do trabalho do Aluno: ");
        NotaTrabalho = double.Parse(Console.ReadLine());

    }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    public bool CalcularNotaFinal()
    {
        Console.WriteLine($"\nAluno: {nome} (RA: {RA})");
        Console.WriteLine($"Nota Final: {NotaFinal}");

        if (NotaFinal >= 6)
        {
            Console.WriteLine("Aluno aprovado! ");
            return true;
        }
        else
        {
            double notaNecessaria = (12 - NotaFinal);
            Console.WriteLine($"Aluno em recuperação. Precisa tirar pelo {notaNecessaria} na prova final.");
            return false;
        }
    }
    public void ImprimirNotaFinal()
    {
        Console.WriteLine($"Nota Final do aluno {nome}: {NotaFinal}");
    }

    class Program
    {
        static void Main()
        {
            Aluno aluno = new Aluno();

            aluno.ReceberDados();

            aluno.CalcularMedia();

            bool aprovado = aluno.CalcularNotaFinal();

            aluno.ImprimirNotaFinal();
         }
    }

}
