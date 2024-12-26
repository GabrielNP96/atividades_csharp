//recebendo dados
Console.Write("Vamos calcular a área de um triângulo!\nDigite a Base: ");
string triangleBaseStr = Console.ReadLine()!;
Console.Write("Digite a altura: ");
string triangleHeightStr = Console.ReadLine()!;

//convertendo
double triangleBase = double.Parse(triangleBaseStr);
double triangleHeight = double.Parse(triangleHeightStr);

//calculando

void TriagleArea(double triangleBase, double triangleHeight)
{
    Console.WriteLine($"A área do triângulo é {(triangleBase * triangleHeight) / 2}");
}

TriagleArea(triangleBase, triangleHeight);


