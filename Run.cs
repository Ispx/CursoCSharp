using CursoCSharp.fundamentos;
using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Run
    {
        public static void Main()
        {
            Dictionary<int, Action> dictionary = new Dictionary<int, Action>(){
                {
                    0 , HelloWord.Executar
                },
                  {
                    1 , VariaveisEConstates.Executar
                },
                 {
                    2 , Inferencia.Executar
                }
            };
            var central = new Central(dictionary);
            central.SelecionarExecutar(1);
        }
    }
}