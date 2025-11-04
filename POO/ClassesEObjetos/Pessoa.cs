
namespace ClassesEObjetos
{
    public class Pessoa
    {
        //Propriedades
        public string Nome = "";
        public int Idade = 0;

        //Métodos
        public void Falar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        //aqui, quem não treina envelhece mais de um ano por vez
        public int Envelhecer(int _anos)
        {
            if (_anos <= 0) 
            {
                Console.WriteLine($"Idade tem que seer positiva!");
                return Idade;//para o código aqui, nÃo le abaixo
            }

            Idade += _anos;//atualiza a idade

            return Idade;
        }
    }// fim da class
}// fim do namespace