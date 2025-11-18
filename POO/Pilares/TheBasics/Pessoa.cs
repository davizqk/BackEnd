
//namespace pode ser considerado como a pasta do projeto
//namespace é o modulo do sistema
//namespace é como um pacote, 

namespace TheBasics
{
    public class Pessoa
    {
        //propriedades
        public string Nome;
        public int Idade;

        public Endereco EnderecoCompleto;

        //construtor
        public Pessoa(Endereco endereco)
        {
            EnderecoCompleto = endereco;
        }

        //métodos
        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou o {Nome} e tenho {Idade} anos");
        }
        public void Envelhecer()
        {
            Idade++;
        }

    }
}
