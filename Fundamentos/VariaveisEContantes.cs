namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstates
    {

        public static void Executar()
        {
            double raio = 4.5;
            Console.WriteLine("Área da circunferencia: " + raio);
            const double PI = 3.14;
            Console.WriteLine("Constane PI: " + PI);
            bool estaChovendo = false;
            Console.WriteLine("Está chovendo: " + estaChovendo);
            Console.WriteLine("Valor máximo do byte: " + byte.MaxValue);
            Console.WriteLine("Valor minímo do byte: " + byte.MinValue);
            Console.WriteLine("Valor máximo do sbyte: " + sbyte.MaxValue);
            Console.WriteLine("Valor minímo do sbyte: " + sbyte.MinValue);
            Console.WriteLine("Valor máximo do inteiro: " + int.MaxValue);
            Console.WriteLine("Valor minímo do inteiro: " + int.MinValue);
            Console.WriteLine("Valor máximo do uint: " + uint.MaxValue);
            Console.WriteLine("Valor minímo do uint: " + uint.MinValue);
            Console.WriteLine("Valor máximo do long: " + long.MaxValue);
            Console.WriteLine("Valor minímo do long: " + long.MinValue);
            float algumPreco = 71.49f;
            Console.WriteLine("Algum preço: " + algumPreco);
            Console.WriteLine("Valor máximo do double: " + double.MaxValue);
            Console.WriteLine("Valor minímo do double: " + double.MinValue);
            Console.WriteLine("Valor máximo do decimal: " + decimal.MaxValue);
            Console.WriteLine("Valor minímo do decimal: " + decimal.MinValue);
            Char oneCaractere = 'G';
            Console.WriteLine("Apenas um caractere: " + oneCaractere);
            string mensagemDeTexto = "Apenas uma mensagem de texto";
            Console.WriteLine(mensagemDeTexto);

        }
    }
}