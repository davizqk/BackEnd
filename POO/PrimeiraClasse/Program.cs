using PrimeiraClasse;

/*

string nome = "Davi Muniz";

//cria um objeto do tipo Hello
Hello cumprimento = new Hello();
//acessa a propriedade TextoHello e adiciona um texto
cumprimento.TextoHello = "Olá usuário";
//acessa o método SaldarUsuario que imprime um texto
cumprimento.SaldarUsuario();
cumprimento.SaldarComNome("Davi Muniz");
*/

//CARRO
/*
Carro c1 = new Carro();
c1.marca = "Lamborghini";
c1.modelo = "Urus";
c1.cor = "Laranja";
c1.qtdPortas = 4;
c1.qtdRodas = 4;
c1.Ligar();
c1.Acelerar();
c1.Frear();
c1.Desligar();

Carro c2 = new Carro();
c2.marca = "Ferrari";
c2.modelo = "SF90";
c2.cor = "Vermelha";
c2.qtdPortas = 2;
c2.qtdRodas = 4;

Console.WriteLine();
Console.WriteLine($"Características: ");
Console.WriteLine();

Console.WriteLine($"------ {c1.marca} ------");
Console.WriteLine($"Carro: {c1.marca}");
Console.WriteLine($"Modelo: {c1.modelo}");
Console.WriteLine($"Cor: {c1.cor}");
Console.WriteLine($"Quantidade de Portas: {c1.qtdPortas}");
Console.WriteLine();
Console.WriteLine($"Ligando o {c1.modelo}");
Console.WriteLine($"Acelerando o {c1.modelo}");
Console.WriteLine($"Freando o {c1.modelo}");
Console.WriteLine($"Desligando o{c1.modelo}");
Console.WriteLine($"---");
Console.WriteLine();

Console.WriteLine($"------ {c2.marca} ------");
Console.WriteLine($"Carro: {c2.marca}");
Console.WriteLine($"Modelo: {c2.modelo}");
Console.WriteLine($"Cor: {c2.cor}");
Console.WriteLine($"Quantidade de Portas: {c2.qtdPortas}");
Console.WriteLine();
Console.WriteLine($"Ligando o {c2.modelo}");
Console.WriteLine($"Acelerando o {c2.modelo}");
Console.WriteLine($"Freando o {c2.modelo}");
Console.WriteLine($"Desligando o{c2.modelo}");
*/

//MOTO

/*
Moto m1 = new Moto();
m1.Marca = "Triumph";
m1.Modelo = "TIGER 1200 GT PRO";
m1.Cor = "Prata";
m1.QtdRodas = 2;
m1.Ligar();
m1.Acelerar();
m1.Frear();
m1.Desligar();

Moto m2 = new Moto();
m2.Marca = "Honda";
m2.Modelo = "Africa Twin";
m2.Cor = "Vermelha";
m2.QtdRodas = 2;

Console.WriteLine($"------ {m1.Marca} ------");
Console.WriteLine($"Moto: {m1.Marca}");
Console.WriteLine($"Modelo: {m1.Modelo}");
Console.WriteLine($"Cor: {m1.Cor}");
Console.WriteLine();
Console.WriteLine($"Ligando a {m1.Modelo}");
Console.WriteLine($"Acelerando a {m1.Modelo}");
Console.WriteLine($"Freando a {m1.Modelo}");
Console.WriteLine($"Desligando a {m1.Modelo}");
Console.WriteLine($"-------");
Console.WriteLine();

Console.WriteLine($"------ {m2.Marca} ------");
Console.WriteLine($"Moto: {m2.Marca}");
Console.WriteLine($"Modelo: {m2.Modelo}");
Console.WriteLine($"Cor: {m2.Cor}");
Console.WriteLine();
Console.WriteLine($"Ligando a {m2.Modelo}");
Console.WriteLine($"Acelerando a {m2.Modelo}");
Console.WriteLine($"Freando a {m2.Modelo}");
Console.WriteLine($"Desligando a {m2.Modelo}");
Console.WriteLine($"-------");
Console.WriteLine();
*/

//Criar uma classe para representar uma garrafa
Console.Clear();
Garrafa g1 = new Garrafa();
Console.Write($"Digite a marca da garrafa: ");
string Marca = Console.ReadLine();

Console.Write($"Digite a capacidade da garrafa: ");
string Capacidade = Console.ReadLine();

Console.Write($"Digite a cor da garrafa: ");
string Cor = Console.ReadLine();

Console.Write($"Digite o material da garrafa: ");
string Material = Console.ReadLine();

Console.Clear();
Console.WriteLine($"---- Garrafa {Marca} ----");
Console.WriteLine($"Marca: {Marca}");
Console.WriteLine($"Capacidade: {Capacidade}ml");
Console.WriteLine($"Cor da garrafa: {Cor}");
Console.WriteLine($"Material da garrafa: {Material}");



/*
g1.Marca = Marca;
g1.Capacidade = ;
g1.Material = "Alumínio";
g1.Cor = "Azul";
*/
g1.Abrir();
g1.Fechar();
g1.Encher();
g1.Esvasiar();
