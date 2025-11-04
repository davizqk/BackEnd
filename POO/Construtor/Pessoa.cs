
namespace Construtor
{
    public class Pessoa
    {
        //propriedades
        public string Nome;
        public int Idade;

        //metodo construtor de Pessoa, possuindo parametros
        /*parametros representam os valores de nome e a idade
        ou seja, estamos inicializando valores para as props
        nome e idade*/
        public Pessoa(string n, int i)
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
