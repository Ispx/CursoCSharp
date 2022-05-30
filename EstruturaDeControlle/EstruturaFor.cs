namespace CursoCSharp.EstruturaDeControlle;

public class EstruturaFor
{
    public static void Executar()
    {

        for (int i = 1; i < 11; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }

    }
}