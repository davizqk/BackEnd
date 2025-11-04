
namespace ExerciciosMetodoConstrutor
{
    public class Aluno2Sobrecarga
    {
        public string Nome;
        public int Nota;

        public Aluno2Sobrecarga()
        {
            Nome = "Desconhecido";
            Nota = 0;
        }
        public Aluno2Sobrecarga(string n, int i)
        {
            Nome = n;
            Nota = i;
        }
    }
}