namespace CursoCSharp.Fundamentos;



public class OperadoresLogicos
{
    public static void Executar()
    {
        Console.WriteLine($"1 é igual a 1 ? {1 == 1}");
        Console.WriteLine($"10 é maior ou igual a 20 ? {10 >= 20}");
        Console.WriteLine($"10 é igual a 20 && 1 é igual a 1? {10 == 20 && 1 == 1}");
        Console.WriteLine($"A é igual a A && B é igual a B? {'A' == 'A' && 'B' == 'B'}");
        Console.WriteLine($"10 é igual a 20 || 1 é igual a 1? {10 == 20 || 1 == 1}");
        Console.WriteLine($"15 é maior que a 20 || 1 é igual a 2? {15 > 20 || 1 == 2}");
    }
}