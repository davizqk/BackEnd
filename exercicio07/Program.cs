/*
7) Crie um menu de console igual ao exibido abaixo, utilizando a estrutra switch do c#:

-------------------------------------------------------
        Bem Vindo, Usuário
-------------------------------------------------------


Escolha uma opção no menu abaixo:

   1) Opção 1
   2) Opção 2
   3) Opção 3
   0) Sair

O programa deve exibir uma mensagem informando a opção que o usuário escolheu ou uma mensagem de opção Inválida.
*/
int opcao;
int contador = 0;
Console.Clear();//limpa tela

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
        break;
    case 2:
        Console.WriteLine($"Sua opção escolhida foi {opcao} - CocaCola");
        break;
    case 3:
        Console.WriteLine($"Sua opção escolhida foi {opcao} - Pepsi");
        break;
    case 0:
        Console.WriteLine($"Sua opção escolhida foi {opcao} - Sair");
        break;
    default:
        Console.WriteLine($"Não temos esta opção {opcao}!!");
        break;
}