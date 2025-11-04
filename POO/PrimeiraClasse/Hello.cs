
namespace PrimeiraClasse
{
    public class Hello
    {
        //Propriedades/Características - variáveis internas dessa clase
        public string TextoHello = "";

        // Métodos/Comportamentos/Ações - são as funções internas dessa classe
        public void SaldarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }

        public void SaldarComNome(string n)
        {
            Console.WriteLine($"Olá {n}");
        }
    }//fim da class
}//fim do namespace