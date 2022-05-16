using System.Globalization;

namespace CursoCSharp.Fundamentos;



public class FormatandoNumeros
{


    public static void Executar()
    {
        double valor = 152.68579;

        Console.WriteLine($"Formatar com uma casa decimal: {valor.ToString("F1")}");

        Console.WriteLine($"Formatar como moeda: {valor.ToString("C")}");
        Console.WriteLine($"Valor em percentual: {valor.ToString("P")}");
        Console.WriteLine($"Formatar customizada: {valor.ToString("#.##")}");

        CultureInfo cultureInfo = new CultureInfo("pt_BR");
        Console.WriteLine($"Formato pt_BR com duas casas decimais: {valor.ToString("C2", cultureInfo)}");

    }

}