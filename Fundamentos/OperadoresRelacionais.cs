namespace CursoCSharp.Fundamentos;

public class OperadoresRelacionais
{

    public static void Executar()
    {

        Console.WriteLine($"({2} + {2}) > 10 ? {(2 + 2) > 10}");
        Console.WriteLine($"({10} - {2}) >= 8 ? {(10 - 2) <= 8}");
        Console.WriteLine($"({5} * {5}) == 25 ? {(5 * 5) == 25}");
        Console.WriteLine($"({100} / {5}) < 50 ? {(100 / 5) < 50}");
        Console.WriteLine($"({10} ˆ {2}) <= 100 ? {(Math.Pow(10, 2) <= 100)}");
        Console.WriteLine($"({125} % {2}) != 1 ? {(125 % 2) != 1}");



    }
}