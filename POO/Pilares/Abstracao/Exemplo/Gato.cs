
namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Gatinho Miau miau :)");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"Movendo as patinhas");
            
        }
    }
}