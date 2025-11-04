
namespace ClassesEObjetos
{
    public class Garrafa
    {
        //propriedades
        public int Capacidade;
        public string Marca;
        public string Cor;
        public string Material;

        //métodos
        public void Abrir()
        {
            Console.WriteLine($"Garrafa abrindo");
        }
        public void Fechar()
        {
            Console.WriteLine($"Garrafa fechando");
        }
        public void Encher()
        {
            Console.WriteLine($"Garrafa enchendo");
        }
        public void Esvaziar()
        {
            Console.WriteLine($"Garrafa esvaziando");
        }

    }
}