/*
6) Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%.
qNa verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7,
ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão
utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno,
e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido,
 começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.
*/
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