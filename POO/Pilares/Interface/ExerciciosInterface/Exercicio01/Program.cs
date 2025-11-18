
// Exercício 1
// Crie uma interface chamada IForma com o método CalcularArea.
// Crie duas classes que implementem essa interface: Retangulo e Circulo.
// No programa, peça os valores necessários e exiba a área calculada para cada forma.
// No Retângulo utilizar o cálculo = Largura * Altura;
// No Círculo utilizar o cálculo = PI * Raio * Raio;
// Extra: Pesquisar sobre a classe Mth do C# e utilizar a constante PI - Math.PI

using Exercicio01;

Console.Clear();
Console.WriteLine($"===== Bem-vindo ao programa Cãlculos de Geometria =====");
Console.WriteLine($"");
Console.WriteLine($"Vamos calcular a área do Retângulo");

//Altura e Largura
Console.Write($"Informe a Largura do Retângulo: ");
float l = float.Parse(Console.ReadLine());
Console.Write($"Informe a Altura do Retângulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Agora vamos calcular a área do Círculo");
Console.Write($"Informe o raio do Círculo: ");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Fim do programa");
Console.WriteLine();
