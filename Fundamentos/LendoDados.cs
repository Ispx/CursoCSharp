using System.Globalization;

namespace CursoCSharp.Fundamentos;



public class LendoDados
{


    public static void Executar()
    {

        Console.WriteLine("Qual o seu primeiro nome?");
        string primeiroNome = Console.ReadLine() ?? "";
        Console.WriteLine("Quantos naos você tem?");
        int idade = int.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        Console.WriteLine("Qual a sua altura?");
        double altura = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
        Console.WriteLine($"Primeiro nome: {primeiroNome}, idade: {idade}, altura: {altura}");





    }



}