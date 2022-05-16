namespace CursoCSharp
{
    public class CentralExercicios
    {
        Dictionary<int, Action> Exercicios;
        public CentralExercicios(Dictionary<int, Action> Exercicios)
        {
            this.Exercicios = Exercicios;
        }

        public void SelecionarExecutar(int exercicio)
        {
            try
            {
                Action Exercicio = Exercicios[exercicio];
                Exercicio();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}