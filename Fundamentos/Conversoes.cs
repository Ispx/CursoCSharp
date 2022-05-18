namespace CursoCSharp.Fundamentos;
public class Conversoes
{
    public static void Executar()
    {
        //Inteiro convertido em double
        int valorInteiro = 10;
        double valorDouble = valorInteiro;
        valorDouble = (double)valorInteiro;
        //Double convertido em inteiro
        valorDouble = 240.678;
        valorInteiro = (int)valorDouble;
        valorInteiro = int.Parse($"{valorDouble}", System.Globalization.NumberStyles.Integer);
        //Tenta converter String convertido para inteiro, caso der erro atribui zero a váriavel
        int.TryParse("10", out valorInteiro);
        int.TryParse("10", out int valorInteiro2);
    }
}


