
using Construtor;

// //davi é uma variavel do
// Pessoa davi = new Pessoa("Davi", 17);

// // davi.Nome = "Davi Muniz";
// // davi.Idade = 18;
// Console.WriteLine($"O objeto pessoa que criei é o {davi.Nome} com a idade {davi.Idade}");

// // davi.Nome = "Walyson";
// davi.ExibirDados();


// Console.WriteLine($"{davi.Nome}");

//primeiro metodo construtor da class Pessoa3Sobrecarga
Pessoa3Sobrecarga PrimeiraPessoa = new Pessoa3Sobrecarga();

Console.WriteLine(@$"Primeira pessoa cadastrada: 
                    Nome: {PrimeiraPessoa.Nome}
                    Idade: {PrimeiraPessoa.Idade}

");

//segundo metodo construtor da class Pessoa3Sobrecarga
Pessoa3Sobrecarga SegundaPessoa = new Pessoa3Sobrecarga("Davi Muniz");

Console.WriteLine(@$"Segunda pessoa cadastrada: 
                    Nome: {SegundaPessoa.Nome}
                    Idade: {SegundaPessoa.Idade}

");

Console.Write($"Digite o nome da terceira pessoa: ");
string nome3 = Console.ReadLine();

Console.Write($"Digite a idade da terceira pessoa: ");
int idade3 = int.Parse(Console.ReadLine());

//terceiro metodo construtor da class Pessoa3Sobrecarga
Pessoa3Sobrecarga TerceiraPessoa = new Pessoa3Sobrecarga(nome3, idade3);

Console.WriteLine(@$"Terceira pessoa cadastrada: 
                    Nome: {TerceiraPessoa.Nome}
                    Idade: {TerceiraPessoa.Idade}

");

