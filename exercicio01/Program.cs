/*
1)Faça um programa que o usuário informe o salário recebido e o total gasto. 
Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse
 o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.
*/
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