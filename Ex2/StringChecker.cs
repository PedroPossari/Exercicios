using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringChecker
{
    public static void VerificarString()
    {
        Console.Write("Digite uma string para verificar a presença da letra 'a': ");
        string input = Console.ReadLine();
        int count = 0;

        foreach (char c in input)
        {
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }

        Console.WriteLine($"A letra 'a' aparece {count} vezes na string.");
    }
}