﻿int n1, n2;

Console.WriteLine("Digite o primeiro número");
n1 = int.Parse(Console.ReadLine());//pega o texto que o usuário digitar e transforma em número
Console.WriteLine("Digite o segundo número");
n2 = int.Parse(Console.ReadLine());//pega o texto que o usuário digitar e transforma em número

if (n1 > n2)
{
    Console.WriteLine($"O primeiro número é maior: " + n1);
}
else if (n2 > n1)
{
    Console.WriteLine($"O segundo número é maior: {n2}");
}
else
{
    Console.WriteLine($"Os números {n1} e {n2} são iguais!");
}

