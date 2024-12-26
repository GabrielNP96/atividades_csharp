//Recebendo o número do usuario e convertendo para int
Console.Write("Vamos descobrir se um número é par ou ímpar.\nDigite um número inteiro positivo: ");
string userNumberStr = Console.ReadLine()!;
int userNumber = int.Parse(userNumberStr);

//Descobrindo se é par

void OddOrEven(int number)
{
    if(number % 2 == 0)
    {
        Console.WriteLine($"{number} é par");
        return;
    }

    Console.WriteLine($"{number} é ímpar");
}

OddOrEven(userNumber);
