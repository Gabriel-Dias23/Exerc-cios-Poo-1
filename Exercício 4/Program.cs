using System;

class Lampada
{
    // Atributo que indica se a lâmpada está ligada ou desligada
    private bool Ligada;

    // Método para ligar a lâmpada
    public void Ligar()
    {
        Ligada = true;
        Console.WriteLine("A lâmpada está ligada.");
    }

    // Método para desligar a lâmpada
    public void Desligar()
    {
        Ligada = false;
        Console.WriteLine("A lâmpada está desligada.");
    }

    // Método para mostrar o estado atual da lâmpada
    public void MostrarEstado()
    {
        if (Ligada)
            Console.WriteLine("A lâmpada está ligada.");
        else
            Console.WriteLine("A lâmpada está desligada.");
    }
}

class Program
{
    static void Main()
    {
        
        Lampada lampada = new Lampada();

        int opcao;
        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Ligar a lâmpada");
            Console.WriteLine("2 - Desligar a lâmpada");
            Console.WriteLine("3 - Mostrar estado da lâmpada");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    lampada.Ligar();
                    break;

                case 2:
                    lampada.Desligar();
                    break;

                case 3:
                    lampada.MostrarEstado();
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
