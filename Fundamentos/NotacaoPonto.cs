

namespace CursoCSharp.Fundamentos;

public class NotacaoPonto
{


    public static void Executar()
    {
        Console.WriteLine("apenas uma mensagem em caixa alta".ToUpper());
        Console.WriteLine("apenas uma mensagem em caixa baixa".ToLower());
        List<string> lista = new List<string>();
        lista.Add("Text 1");
        lista.Add("Text 2");
        Console.WriteLine($"Tamanho da lista de texto: {lista.Count}");

    }

}