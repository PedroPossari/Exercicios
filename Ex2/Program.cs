using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Verificar se um número pertence à sequência de Fibonacci");
            Console.WriteLine("2. Verificar a presença e contagem de 'a' em uma string");
            Console.WriteLine("3. Calcular percentual de representação dos estados no faturamento");
            Console.WriteLine("4. Inverter os caracteres de uma string");
            Console.WriteLine("0. Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    FibonacciChecker.VerificarFibonacci();
                    break;
                case "2":
                    StringChecker.VerificarString();
                    break;
                case "3":
                    Faturamento.CalcularPercentualFaturamento();
                    break;
                case "4":
                    StringInverter.InverterString();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}