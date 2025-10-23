/*
9) altere o exercício anterior para que cada opção escolhida pelo usuário seja respondida por uma função,
 ou seja, cada opção deve dar um Console.WriteLine() da opção escolhida.
*/

int opcao;
Console.Clear();//limpa tela
do
{
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("    Bem-vindo, Usuário ");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Escoha uma opção no menu abaixo:");
    Console.WriteLine("1 - Fanta");
    Console.WriteLine("2 - CocaCola");
    Console.WriteLine("3 - Pepsi");
    Console.WriteLine("0 - Sair");
    opcao = int.Parse(Console.ReadLine());//Armazena o que o usuário digitou na variável
    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            escolha1();
            break;
        case 2:
            escolha2();
            break;
        case 3:
            escolha3();
            break;
        case 0:
            escolha4();
            break;
        default:
            Console.WriteLine($"Não temos esta opção {opcao}!!");
            break;
    }


} while (opcao != 0);

void escolha1()
{
    Console.WriteLine($"Sua opção escolhida foi {opcao} - Fanta");
    Console.WriteLine();
    Console.WriteLine();
}

void escolha2()
{
    Console.WriteLine($"Sua opção escolhida foi {opcao} - CocaCola");
    Console.WriteLine();
    Console.WriteLine();
}

void escolha3()
{
    Console.WriteLine($"Sua opção escolhida foi {opcao} - Pepsi");
    Console.WriteLine();
    Console.WriteLine();
}

void escolha4()
{
    Console.WriteLine($"Sua opção escolhida foi {opcao} - Sair");
    Console.WriteLine();
    Console.WriteLine();
}