// Converter uma quantidade de dinheiro de uma moeda para outra.
Console.WriteLine("Bem vindo ao Conversor Real e dollar");

//recebendo dados
Console.WriteLine(@"
Escolha como quer Converter:

1 - Dólar para Real
2 - Real para Dólar");

string inputOptionStr = Console.ReadLine()!;

Console.Write("Digite a quantidade a converter: ");
string valueToConvertStr = Console.ReadLine()!;

//convertendo dados
int inputOption = int.Parse(inputOptionStr);
double valueToConvert = double.Parse(valueToConvertStr);

//realizando conversão


void Conversor(int valueInput,double valueToConvert)
{
    if(valueToConvert <= 0)
    {
        Console.WriteLine("0 não pode ser convertido");
        return;
    }

    switch(valueInput)
    {
        case 1:
            Console.WriteLine($"{valueToConvert} em dólar e igual a ${valueToConvert * 6.20} reais");
            break;
        case 2:
            Console.WriteLine($"{valueToConvert} em Reais e igual a ${valueToConvert / 6.20} dólares");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Conversor(inputOption, valueToConvert);