
/*
5) As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, 
calcule e escreva o valor total da compra.
*/

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
