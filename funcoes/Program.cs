Console.Clear();
Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"Digite seu sobrenome");
string sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}! Agora vamos dar as boas vindas a voce!!");

Console.WriteLine($"Por favor escolha uma opção abaixo:");
Console.WriteLine($"    1 - Saudar com nome");
Console.WriteLine($"    2 - Saudar com sobrenome");
Console.WriteLine($"    3 - Saudar com nome e sobrenome");
Console.WriteLine($"    0 - Apenas saudação genérica");
Console.Clear();

int opcao = 0;
switch (opcao)
{
    case 0:
        SaudacaoGenerica();
        break;
    case 1:
        SaudarComNome(nome);
        break;
    case 2:
        SaudarComSobrenome(sobrenome);
        break;
    case 3:
        string nomeCompleto = SaudarComNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem-vindo {nomeCompleto}");
        break;
    default:
        break;
}

void SaudacaoGenerica()
{
    Console.WriteLine($"Olá, seja bem-vindo ao nosso programa, tenha um ótimo dia :)");
}

void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem-vindo, {nomeRecebido}");
}

void SaudarComSobrenome(string sobrenomeRecebido)
{
    Console.WriteLine($"Seja bem-vindo, {sobrenomeRecebido}");
}

string SaudarComNomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} { sobrenomeRecebido}";
}