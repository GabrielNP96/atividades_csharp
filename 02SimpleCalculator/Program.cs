//recebe dados do usuario
Console.Write("Vamos fazer um calculo simples!\nDigite um número: ");
string userNumber1 = Console.ReadLine()!;
Console.Write("Digite um dos seguintes operadores (+, -, *, /) :");
string mathOperator = Console.ReadLine()!;
Console.Write("Digite mais um número: ");
string userNumber2 = Console.ReadLine()!;

//convertendo dados
double firstNumber = double.Parse(userNumber1);
double secondNumber = double.Parse(userNumber2);

//calculando

void Calculator(double number1, string mathOperator, double number2)
{
    if (mathOperator == "+")
    {
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
    } else if (mathOperator == "-")
    {
         Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
    } else if (mathOperator == "*")
    {
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
    } else if (mathOperator == "/")
    {
        if(number2 == 0)
        {
            Console.WriteLine("Não é possivel dividir por 0!");
            return;
        }

        Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
    } else
    {
        Console.WriteLine($"{mathOperator} não é um operador válido");
    }
}

Calculator(firstNumber, mathOperator, secondNumber);