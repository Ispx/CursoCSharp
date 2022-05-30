namespace CursoCSharp.EstruturaDeControlle;



public class EstruturaSwitch
{

    public static void Executar()
    {
        int i = new Random().Next(1, 4);
        switch (i)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                throw new Exception("unknow");
        }







    }


}