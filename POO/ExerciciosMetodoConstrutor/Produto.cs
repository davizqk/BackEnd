
namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
        //propriedades
        public string Nome;
        public double Preco;
        public int Estoque;

        //construtores
        public Produto(string n, double p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        //metodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}  Preço: {Preco}  Estoque: {Estoque}");
        }
    }
}