
namespace Construtor
{
    public class Pessoa3Sobrecarga
    {
        public string Nome;
        public int Idade;


        public Pessoa3Sobrecarga()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }
        public Pessoa3Sobrecarga(string n)
        {
            Nome = n;
            Idade = 0;
        }
        public Pessoa3Sobrecarga(string n, int i)
        {
            Nome = n;   //inicializa com o valor de n
            Idade = i;  //inicializa com o valor de i
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}  Idade: {Idade}");
        }
    }
}