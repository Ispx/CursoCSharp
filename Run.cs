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
                    0 , VariaveisEConstates.Executar
                },
                 {
                    1 , Inferencia.Executar
                },
                {
                    2 , Interpolacao.Executar
                },
                {
                    3 , NotacaoPonto.Executar
                },
                {
                    4 , LendoDados.Executar
                }
                ,
                {
                    5 , FormatandoNumeros.Executar
                }
            };
            var central = new CentralExercicios(dictionary);
            central.SelecionarExecutar(5);
        }
    }
}