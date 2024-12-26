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
} else if (secondNumber > firstNumber)
{
    Console.WriteLine($"{secondNumber} é maior que {firstNumber}");
} else if (firstNumber == secondNumber)
{
    Console.WriteLine($"{firstNumber} é igual a {secondNumber}");
} else {
    Console.WriteLine($"Ocorreu um erro....");
}