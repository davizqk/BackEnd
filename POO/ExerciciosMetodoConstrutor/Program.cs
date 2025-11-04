
using ExerciciosMetodoConstrutor;

/*
//========== CARRO ==========\\
Carro c1 = new Carro("Porsche", "911", 2025);

c1.ExibirDados();
*/

/*
//========== ALUNO ==========\\
Aluno2Sobrecarga PrimeiroAluno = new Aluno2Sobrecarga();
Console.WriteLine(@$"Primeiro aluno cadastrado: 
                    Nome: {PrimeiroAluno.Nome}
                    Nota: {PrimeiroAluno.Nota}

");

Aluno2Sobrecarga SegundoAluno = new Aluno2Sobrecarga("Davi Muniz", 10);
Console.WriteLine(@$"Segundo aluno cadastrado: 
                    Nome: {SegundoAluno.Nome}
                    Nota: {SegundoAluno.Nota}

");
*/

/*
//========== PRODUTO ==========\\
Produto p1 = new Produto("Shampoo", 14.99, 20);

p1.ExibirDados();
*/

/*
//========== CONTA BANCARIA ==========\\
ContaBancaria2Sobrecarga ContaBancaria = new ContaBancaria2Sobrecarga("Davi Muniz");
Console.WriteLine(@$"Conta 1: 
                    Nome: {ContaBancaria.Titular}
                    Nota: {ContaBancaria.SaldoInicial}

");

ContaBancaria2Sobrecarga ContaBancaria2 = new ContaBancaria2Sobrecarga("Davi Muniz", 1000);
Console.WriteLine(@$"Conta 2: 
                    Nome: {ContaBancaria2.Titular}
                    Nota: {ContaBancaria2.SaldoInicial}

");
*/

//========== MEDIA ALUNO ==========\\
MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.Nome = "Waly";
a1.Media();

MediaAluno a2 = new MediaAluno();
a2.Nome = "Davi";
a2.Media();
