
using System.Runtime.Intrinsics.X86;

namespace Exercicio01
{
    public class Circulo : IForma
    {
        public float Raio;
        public float PI = 3.14f;
        public void CalcularArea()
        {
            Console.WriteLine($"A área do círculo é {PI * Raio * Raio}");
            // PI * Raio * Raio;
        }
    }
}