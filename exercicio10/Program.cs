/*
10) Baseado no programa do exercício número 9, crie um programa que contenha 
o menu para os exercícios de 1 a 6, onde cada programa/menu deve executar uma função.
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
    Console.WriteLine("1 - Exercicio 01");
    Console.WriteLine("2 - Exercicio 02");
    Console.WriteLine("3 - Exercicio 03");
    Console.WriteLine("4 - Exercicio 04");
    Console.WriteLine("5 - Exercicio 05");
    Console.WriteLine("6 - Exercicio 06");
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
        case 4:
            escolha4();
            break;
        case 5:
            escolha5();
            break;
        case 6:
            escolha6();
            break;
        case 0:
            Console.WriteLine($"Não temos esta opção {opcao}!!");
            break;
        default:
            Console.WriteLine($"Não temos esta opção {opcao}!!");
            break;
    }


} while (opcao != 0);

void escolha1()
{
    int salario, totalGasto;

    Console.WriteLine("Digite o seu salário: ");
    salario = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o total gasto: ");
    totalGasto = int.Parse(Console.ReadLine());

    int dinheiroSobrando = salario - totalGasto;

    if (salario >= totalGasto)
    {
        Console.WriteLine("Gastos dentro do orçamento!");
        Console.WriteLine($"Dinheiro sobrando {dinheiroSobrando}");
    }
    else
    {
        Console.WriteLine("Orçamento estourado!");
    }
}

void escolha2()
{
    string time1, time2;
    int golsTimeUm, golsTimeDois;

    Console.WriteLine("Digite o primeiro time: ");
    time1 = (Console.ReadLine());

    Console.WriteLine("Digite o segundo time: ");
    time2 = (Console.ReadLine());

    Console.WriteLine("Digite os gols do Time 1: ");
    golsTimeUm = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite os gols do Time 2: ");
    golsTimeDois = int.Parse(Console.ReadLine());

    if (golsTimeUm > golsTimeDois)
    {
        Console.WriteLine($"Vitória do {time1}");
        Console.WriteLine($"Placar: {golsTimeUm} X {golsTimeDois}");
    }
    else if (golsTimeDois > golsTimeUm)
    {
        Console.WriteLine($"Vitória do {time2}");
        Console.WriteLine($"Placar: {golsTimeUm} X {golsTimeDois}");
    }
    else
    {
        Console.WriteLine("O jogo terminou EMPATADO!");
        Console.WriteLine($"Placar: {golsTimeUm} X {golsTimeDois}");
    }
}

void escolha3()
{
    double lado1, lado2, lado3;

    Console.WriteLine("Digite o primeiro lado do triângulo:");
    lado1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo lado do triângulo:");
    lado2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o terceiro lado do triângulo:");
    lado3 = double.Parse(Console.ReadLine());

    if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2))
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("Triângulo Equilátero");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("Triângulo Isósceles");
        }
        else
        {
            Console.WriteLine("Triângulo Escaleno");
        }
    }
    else
    {
        Console.WriteLine("As medidas informadas não formam um triângulo.");
    }
}

void escolha4()
{
    int senha = 1234, senhaDigitada;

    Console.WriteLine("Digite a senha correta: ");
    senhaDigitada = int.Parse(Console.ReadLine());

    if (senhaDigitada == senha)
    {
        Console.WriteLine("ACESSO PERMITIDO");
    }
    else
    {
        Console.WriteLine("ACESSO NEGADO");
    }
}

void escolha5()
{
    int quantidade;
    double preco = 0 ;

    Console.Write("Digite o número de maçãs compradas: ");
    quantidade = int.Parse(Console.ReadLine());

    if (quantidade >= 12)
    {
        preco = 0.25;
    }
    else
    {
        preco = 0.30;
    }

    double total = quantidade * preco;

    Console.WriteLine($"O valor total da compra é: R$ {total:F2}");
}

void escolha6()
{
    double media;
    int frequencia;

    Console.Write("Digite a média do aluno: ");
    media = double.Parse(Console.ReadLine());

    Console.Write("Digite a frequência do aluno (em %): ");
    frequencia = int.Parse(Console.ReadLine());

    if (frequencia < 75)
    {
        Console.WriteLine("Aluno REPROVADO por frequência.");
        Console.WriteLine($"Frequencia: {frequencia}, Media: {media}");
    }
    else if (media >= 7.0)
    {
        Console.WriteLine("Aluno APROVADO.");
        Console.WriteLine($"Frequencia: {frequencia}, Media: {media}");
    }
    else if (media >= 3.0)
    {
        Console.WriteLine("Aluno em RECUPERAÇÃO.");
        Console.WriteLine($"Frequencia: {frequencia}, Media: {media}");
    }
    else
    {
        Console.WriteLine("Aluno REPROVADO por média.");
        Console.WriteLine($"Frequencia: {frequencia}, Media: {media}");
    }
}
