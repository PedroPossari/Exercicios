using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public static class Faturamento
{
    public static void CalcularPercentualFaturamento()
    {
        
        string caminhoArquivo = "Faturamento.xml";

        
        XDocument doc = XDocument.Load(caminhoArquivo);

        
        Dictionary<string, double> faturamentoPorEstado = doc.Descendants("Estado")
            .ToDictionary(
                e => e.Attribute("Nome").Value,
                e => double.Parse(e.Attribute("Valor").Value)
            );

        
        double faturamentoTotal = faturamentoPorEstado.Values.Sum();

        
        foreach (var estado in faturamentoPorEstado)
        {
            double percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"Estado: {estado.Key} - Faturamento: R${estado.Value:F2} - Percentual: {percentual:F2}%");
        }
    }
}