
namespace ExerciciosMetodoConstrutor
{
    public class ContaBancaria2Sobrecarga
    {
        //propriedades
        public string Titular;
        public int SaldoInicial;

        //construtores
        public ContaBancaria2Sobrecarga(string t)
        {
            Titular = t;
            SaldoInicial = 0;
        }
        public ContaBancaria2Sobrecarga(string t, int s)
        {
            Titular = t;
            SaldoInicial = s;
        }

        //metodos
        public void ExibirDados()
        {
            Console.WriteLine($"Titular: {Titular}  SaldoInicial: {SaldoInicial}");
        }
    }
}