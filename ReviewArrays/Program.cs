//Arrays

Console.Clear();
string nome = "Eduardo";
Console.WriteLine($"Nome: {nome}");
//cria um array tamanho 4 e preenche com vazio
string[] nomes = new string[4];//tamanho é 4 - de 0 a 3
int[] idade = new int[4];
int opcao = -1, totalAlunos = 0;

/*
nomes[0] = "Maria";
idade[0] = 20;

nomes[1] = "Matheus";
idade[1] = 16;

nomes[2] = "Eloysa";
idade[2] = 17;

nomes[3] = "Felipe";
idade[3] = 18;
*/

do 
{ 
    Console.Clear();
    Console.WriteLine($"1 - Cadastrar Alunos");
    Console.WriteLine($"2 - Listar Alunos");
    Console.WriteLine($"3 - Sair");
    Console.Write($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    //chamar a função
    switch(opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");
            Console.WriteLine($"Pressione <Enter> para encerrar...");
            Console.ReadLine();
            break;
        case 1:
            CadastrarAluno();
            break;
        case 2:
            ListarAlunos();
            break;
        default:
            Console.WriteLine($"Opção Inválida, pressione <Enter> para continuar...");
            Console.ReadLine();//para o sistema e espera o usuário digitiar Enter!!
            break;
        
    }//fim do switch
} while (opcao != 0);

//=============== Funções ===============


//Função para cadastrar aluno
void CadastrarAluno()
{
    //verificar espaço no array para cadastrar (totalAlunos)
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Limite de ocupação atingido");
        return;
    }
    //pedir os dados para o usuário(nome, idade)
    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    //guardar/cadastrar no array
    nomes[totalAlunos] = n;
    idade[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} alunos(s) cadastrado(s) no sistema");
    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();//parar o sistema e esperar o usuário dar um <Enter>
}


//Função para exibir os alunos 
void ListarAlunos()
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: ");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"   Nome: {nomes[i]}");
        Console.WriteLine($"   Idade: {idade[i]}");
        Console.WriteLine();
    }
}
