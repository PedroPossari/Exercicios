using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringInverter
{
    public static void InverterString()
    {
        Console.Write("Digite uma string para inverter: ");
        string input = Console.ReadLine();
        string resultado = Inverter(input);
        Console.WriteLine($"String invertida: {resultado}");
    }

    private static string Inverter(string str)
    {
        char[] caracteres = str.ToCharArray();
        int esquerda = 0;
        int direita = caracteres.Length - 1;

        while (esquerda < direita)
        {
            char temp = caracteres[esquerda];
            caracteres[esquerda] = caracteres[direita];
            caracteres[direita] = temp;

            esquerda++;
            direita--;
        }

        return new string(caracteres);
    }
}
