
using TheBasics;
Console.Clear();

//array/lista de pessoas
// List<Pessoa> peoples = new List<Pessoa>();

// Endereco endDavi = new Endereco();
// endDavi.Logradouro = "Rua Cachoeira Dourada";
// //Pessoa com Endereco
// Pessoa Davi = new Pessoa(endDavi);
// Davi.Nome = "Davi Muniz";
// Davi.Idade = 17;

// Endereco endWaly = new Endereco();
// endWaly.Logradouro = "Rua Monsenhor Pizzarro";
// //Pessoa com Endereco
// Pessoa Waly = new Pessoa(endWaly);
// Waly.Nome = "Walysson Menezes";
// Waly.Idade = 17;

// Endereco endSamuel = new Endereco();
// endSamuel.Logradouro = "Rua Do Pacificador";
// //Pessoa com Endereco
// Pessoa Samuel = new Pessoa(endSamuel);
// Samuel.Nome = "Samuel Sousa";
// Samuel.Idade = 17;

// Endereco endMurilo = new Endereco();
// endMurilo.Logradouro = "Rua Riga";
// //Pessoa com Endereco
// Pessoa Murilo = new Pessoa(endMurilo);
// Murilo.Nome = "Murilo Pereira";
// Murilo.Idade = 17;

/*
Davi.Logradouro = "Rua Cachoeira Dourada";
Davi.Numero = 188;

Waly.Logradouro = "Rua Monsenhor Pizzarro";
Waly.Numero = 27;
Waly.Complemento = "Travessa Vista Alegre";

Samuel.Logradouro = "Rua Do Pacificador";
Samuel.Numero = 90;

Murilo.Logradouro = "Rua Riga";
Murilo.Numero = 399;
*/
// guardando os dados na lista

// peoples.Add(Davi);//0
// peoples.Add(Waly);//1
// peoples.Add(Samuel);//2
// peoples.Add(Murilo);//3

// //trocar pelo for
// foreach (Pessoa p in peoples)
// {
//     Console.WriteLine($"Nome: {p.Nome}");
// }

// Endereco endDavi = new Endereco();
// endDavi.Logradouro = "Rua Cachoeira Dourada";
// endDavi.Numero = 188;
// Aluno daviMuniz = new Aluno(endDavi);
// daviMuniz.Nome = "Davi Muniz";
// daviMuniz.Curso = "Desenvolvimento de Sistemas";
// daviMuniz.RA = "111970666-X";
// daviMuniz.NotaFinal = 10.0f;

// Endereco endWaly = new Endereco();
// endWaly.Logradouro = "Rua Monsenhor Pizzarro";
// endWaly.Numero = 27;
// Aluno walyMene = new Aluno(endWaly);
// walyMene.Nome = "Waly Menezes";

// Console.WriteLine($"Aluno {daviMuniz.Nome} estuda na turma {daviMuniz.Curso} da profa {walyMene.Nome}");

Carro Porsche = new Carro();
Porsche.Marca = "Porsche";
Porsche.Modelo = "911 carrera S";
Porsche.QtdRodas = 4;

Moto Triumph = new Moto();
Triumph.Marca = "Triumph";
Triumph.Modelo = "1200 GT PRO";
Triumph.QtdRodas = 2;

Porsche.Ligar();
Porsche.AbrirPortaMalas();

Triumph.Ligar();
Triumph.Empinar();
