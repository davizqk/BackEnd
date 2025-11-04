
namespace PrimeiraClasse
{
    public class Moto
    {
        //propriedades
        public int QtdRodas;
        public string Marca;
        public string Modelo;
        public string Cor;

        //métodos
        public void Acelerar()
        {
            Console.WriteLine($"Moto Acelerando");

        }
        public void Frear()
        {
            Console.WriteLine($"Moto Freando");

        }
        public void Ligar()
        {
            Console.WriteLine($"Moto Ligando");
            
        }
        public void Desligar()
        {
            Console.WriteLine($"Moto Desligando");

        }
    }
}