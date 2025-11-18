
namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";

        public Contrato(string contratante, string contratada, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClausulas = txtClausulas;
        }
        public void Imprimir()
        {
            Console.WriteLine(@$"
        Partes:
            Contratantes: {Contratante}
            Contratado(a): {PrestadorServico}
            Cláusulas do Contrato:

            {TextoClausulas}
            --
            ");
        }
    }
}