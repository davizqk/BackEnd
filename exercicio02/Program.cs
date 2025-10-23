/*
2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol 
(os gols de cada time) e informa se o resultado foi um empate, 
se a vitória foi do primeiro time ou do segundo time.
*/
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