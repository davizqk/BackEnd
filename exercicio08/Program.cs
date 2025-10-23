/*
8) Faça uma alteração no programa acima do menu para que ele funcione em loop. 
Pra isso utilize o laço do while do c#.
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

    switch(opcao)
    {
        case 1:
            Console.WriteLine($"Sua opção escolhida foi {opcao} - Fanta");
            Console.WriteLine();
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine($"Sua opção escolhida foi {opcao} - CocaCola");
            Console.WriteLine();
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine($"Sua opção escolhida foi {opcao} - Pepsi");
            Console.WriteLine();
            Console.WriteLine();
            break;
        case 0:
            Console.WriteLine($"Sua opção escolhida foi {opcao} - Sair");
            break;
        default:
            Console.WriteLine($"Não temos esta opção {opcao}!!");
            break;
    }


} while (opcao != 0);