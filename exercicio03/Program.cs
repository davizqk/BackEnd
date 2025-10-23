/*
3) Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele é Equilátero, Isósceles ou Escaleno.
Sendo que:     

   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
   − Triângulo    Isóscele:    possui    2    lados    iguais.     
   − Triângulo    Escaleno:    possui    3    lados    diferentes.
*/

int medida1, medida2, medida3;

Console.WriteLine("Digite a primeira medida do triangulo: ");
medida1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda medida do triangulo: ");
medida2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira medida do triangulo: ");
medida3 = int.Parse(Console.ReadLine());

if (medida1 = medida2 = medida3)
{
    Console.WriteLine("O triangulo é equilátero");
}
else if (medida1 == medida2)
{
    Console.WriteLine("O triangulo é isósceles");
}
else
{
    Console.WriteLine("O triangulo é escaleno");
}
