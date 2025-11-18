
using System.Diagnostics;

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            Valor = valFat;
            DiasDeAtraso = qtdAtraso;
        }
        public void Imprimir()
        {
            //Calcular o Júros antes de usar o valor da Fatura
            CalcularValorDivida();

            Console.WriteLine(@$"
        Credor: {Credor}
        Devedor: {Devedor}
        Dias de atraso: {Devedor} dia(s)
        Válor: R${Valor:F2}
        Júros: R${(Juros * DiasDeAtraso):F2}
        Total com Júros: {Valor}
            ");//Ja pula uma linha
        }

        public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }

            if (DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Divida encaminhada para o SERASA");
            }
        }
    }
}