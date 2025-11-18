
using System.Runtime.CompilerServices;
using Exercicio02;
Console.Clear();

List<IImprimivel> documentos = new List<IImprimivel>();

Fatura fatEdu = new Fatura("Davi", "Spotify", 23.90f, 1);
Relatorio relWaly = new Relatorio("Davi", "Walyson é babaca demais, passa dos limites em alguns momentos");
Contrato conPaulo = new Contrato("Davi", "Paulo", "20 reais, sem nenhum direito");

int opcao;
do
{
    Console.Clear();
    //Desenha io Menu
    Console.WriteLine($"Menu de Opções");
    Console.Write($@"
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatórios
    6) Listar Contratos 
    0) Sair
    Escolha uma das opções acima:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFatura();
            break;
        case 2:
            CadastrarRelatorio();
            break;
        case 3:
            CadastrarContrato();
            break;
        case 4:
            ListarFaturas();
            break;
        case 5:
            ListarRelatorios();
            break;
        case 6:
            ListarContratos();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;

    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();//Para o console para dar tempo de ver as mensagens do programa

} while (opcao != 0);

// ===== FUNÇÕES ===== \\

void CadastrarFatura()
{
    Console.Write($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();
    Console.Write($"Digite o nome do credor: ");
    string cred = Console.ReadLine();
    Console.Write($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());
    Console.Write($"Quantos dias a fatura está em atraso?");
    int diasAtraso = int.Parse(Console.ReadLine());

    //cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    //cadastra a fatura na lista
    documentos.Add(f);
}

void CadastrarContrato()
{
    Console.Write($"Digite o nome de quem esta contratando:");
    string contratante = Console.ReadLine();
    Console.Write($"Digite o nome de quem esta sendo contratado: ");
    string contratada = Console.ReadLine();
    Console.Write($"Digite as clausulas do contrato: ");
    string txtClausulas = Console.ReadLine();

    //cria o objeto do contrato
    Contrato c = new Contrato(contratante, contratada, txtClausulas);
    //cadastra o contrato na lista
    documentos.Add(c);
}

void CadastrarRelatorio()
{
    Console.Write($"Digite o nome do responsável: ");
    string responsavel = Console.ReadLine();
    Console.Write($"Digite o relatório: ");
    string txtRelatorio = Console.ReadLine();

    //cria o objeto do Relatorio
    Relatorio r = new Relatorio(responsavel, txtRelatorio);
    //cadastra o relatorio na lista
    documentos.Add(r);
}

void ListarFaturas()
{
    Console.WriteLine($"Listando as faturas: ");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarContratos()
{
    Console.WriteLine($"Listando as contratos: ");
    foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorios()
{
    Console.WriteLine($"Listando as relatorios: ");
    foreach (var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}
