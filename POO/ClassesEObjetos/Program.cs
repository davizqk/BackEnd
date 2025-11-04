
using ClassesEObjetos;

//Criar uma classe para representar uma garrafa

/*
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


//g1.Marca = Marca;
//g1.Capacidade = 500ml;
//g1.Material = "Alumínio";
//g1.Cor = "Azul";


g1.Abrir();
g1.Fechar();
g1.Encher();
g1.Esvaziar();
*/


    Console.Clear();
    Console.WriteLine($"== Agência Bancária ==");
    Console.Write($"Digite o nome do titular da conta:");
    string nomeT = Console.ReadLine();
    ContaBancaria conta = new ContaBancaria(nomeT);
    Console.WriteLine();
    Console.WriteLine($"Bem-vindo, {conta.Titular}");
    Console.WriteLine($"Saldo inicial: R$ {conta.Saldo:F2}");
    Console.WriteLine();


int opcao = 0;
    do
    {
        Console.WriteLine($"\n Menu");
        Console.WriteLine($"1 - Depositar");
        Console.WriteLine($"2 - Sacar");
        Console.WriteLine($"0 - Sair");
        Console.Write($"Escolha uma opção: ");
        opcao = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (opcao)
        {
        case 0;
            Console.WriteLine($"Saindo...");
            break;
        case 1:
            Console.Write($"Digite o valor do depósito: R$");
            double deposito = Convert.ToDouble(Console.ReadLine());
            conta.Depositar;
            break;
        case 2:
            Console.Write($"Digite o valor do saque: R$");
            double saque = Convert.ToDouble(Console.ReadLine());
            conta.Sacar;
            break;
        default:
            Console.WriteLine($"Opção invalida, tente novamente.");
            break;
            
        }
    }
    
    /*
    Console.Write($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
        Console.WriteLine($"Saindo...");
            break;
        case 1:
            ContaBancaria.Sacar;
            break;
        case 2:
            ContaBancaria.Depositar
            break;
        default:
        
            break;
    }
*/

/*
Console.Clear();
Pessoa joao = new Pessoa();
joao.Nome = "João Silva";
Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");
//0

int novaIdade = joao.Envelhecer(17);//atualiza e devolve a idade
Console.WriteLine($"{joao.Nome} tem {novaIdade} anos");
//17

joao.Envelhecer(-50);//devolve a idade antiga: 17
Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");
*/
