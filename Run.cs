using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControlle;

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
                ,
                {
                    6 , Conversoes.Executar
                }
                ,
                {
                    7 , OperadoresAritimeticos.Executar
                }
                 ,
                {
                    8 , OperadoresRelacionais.Executar
                }
                ,
                {
                    9 , OperadoresLogicos.Executar
                }
                  ,
                {
                    10 , EstruturaIf.Executar
                }
            };
            var central = new CentralExercicios(dictionary);
            central.SelecionarExecutar(8);
        }
    }
}