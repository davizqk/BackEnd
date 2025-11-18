
namespace TheBasics
{
    public class Aluno : Pessoa
    {
        //Cria um construtor na classe Aluno que recebe endereço
        //e chama o contrutor da classe mãe (base) e repassa o 
        //endereço para ela.
        public Aluno(Endereco endereco) : base(endereco)
        {
        }
        public string RA;
        public float NotaFinal;
        public string Curso;
    }
}