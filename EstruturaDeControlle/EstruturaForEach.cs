namespace CursoCSharp.EstruturaDeControlle;


public class EstruturaForEach
{
    public static void Executar()
    {
        var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int i in list)
        {
            Console.WriteLine($"Número: {i}");
        }
    }

}