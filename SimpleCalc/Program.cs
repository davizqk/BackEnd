/*
Pedir o nome do usuário,
pedir dois números e 
mostrar a soma dos números no final
*/
string nome;
int numero1;
int numero2;
int resultado;

//pedir o nome pro usuário
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();//pede o nome do usuário

//pedir os dois números
Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());//pede o 1 número
Console.WriteLine("Digite o primeiro numero");
numero2 = int.Parse(Console.ReadLine());//pede o 2 número

//somar os dois números
resultado = numero1 + numero2;

// exibir nome e a soma
Console.WriteLine(nome);
Console.WriteLine(resultado);
