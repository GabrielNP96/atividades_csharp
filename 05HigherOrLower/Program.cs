//recebendo dados
Console.Write("Digite um número: ");
string firstNumberStr = Console.ReadLine()!;
Console.Write("Digite outro número: ");
string secondNumberStr = Console.ReadLine()!;

//convertendo dados
double firstNumber = double.Parse(firstNumberStr);
double secondNumber = double.Parse(secondNumberStr);

//verificando maior ou menor

if(firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} é maior que {secondNumber}");
} else {
    Console.WriteLine($"{secondNumber} é maior que {firstNumber}");
}