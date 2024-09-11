using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class FibonacciChecker
{
    public static void VerificarFibonacci()
    {
        Console.Write("Digite um número para verificar se ele pertence à sequência de Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            bool pertence = PertenceFibonacci(numero);
            Console.WriteLine(pertence ? $"{numero} pertence à sequência de Fibonacci." : $"{numero} não pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
        }
    }

    private static bool PertenceFibonacci(int numero)
    {
        if (numero < 0) return false;

        int a = 0, b = 1;
        while (b < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == numero;
    }
}
