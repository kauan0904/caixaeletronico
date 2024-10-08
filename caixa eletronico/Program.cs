using System;

class Program
{
    static void Main(string[] args)
    {
        double saldo = 0;

        while (true)
        {
            Console.WriteLine("\n--- Caixa Eletrônico ---");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Mostrar Saldo");
            Console.WriteLine("4. Transferir");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Informe o valor do depósito: R$");
                double valorDeposito = Convert.ToDouble(Console.ReadLine());
                if (valorDeposito > 0)
                {
                    saldo += valorDeposito;
                    Console.WriteLine($"Depósito de R${valorDeposito:F2} realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Valor do depósito deve ser positivo.");
                }
            }
            else if (opcao == "2")
            {
                Console.Write("Informe o valor do saque: R$");
                double valorSaque = Convert.ToDouble(Console.ReadLine());
                if (valorSaque > 0 && valorSaque <= saldo)
                {
                    saldo -= valorSaque;
                    Console.WriteLine($"Saque de R${valorSaque:F2} realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Saque inválido. Verifique seu saldo ou valor.");
                }
            }
            else if (opcao == "3")
            {
                Console.WriteLine($"Saldo atual: R${saldo:F2}");
            }
            else if (opcao == "4")
            {
                Console.Write("Informe o valor da transferência: R$");
                double valorTransferencia = Convert.ToDouble(Console.ReadLine());
                if (valorTransferencia > 0 && valorTransferencia <= saldo)
                {
                    saldo -= valorTransferencia;
                    Console.Write("Informe o nome do titular da conta de destino: ");
                    string nomeDestinatario = Console.ReadLine();
                    Console.WriteLine($"Transferência de R${valorTransferencia:F2} para {nomeDestinatario} realizada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Transferência inválida. Verifique seu saldo ou valor.");
                }
            }
            else if (opcao == "5")
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}