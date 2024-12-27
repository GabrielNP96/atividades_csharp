// Converter uma quantidade de dinheiro de uma moeda para outra.
Console.WriteLine("Bem vindo ao Conversor Real e dollar");
bool i = true;
while(i != false)
{
    //recebendo dados
    Console.WriteLine(@"Escolha para qual moeda converter:
                        1 - Dollar
                        2 - Real");
    string inputOptionStr = Console.ReadLine()!;

    Console.Write("Digite a quantidade a converter: ");
    string valueToConvertStr = Console.ReadLine()!;

    //convertendo dados
    int inputOption = int.Parse(inputOptionStr);
    double valueToConvert = double.Parse(valueToConvertStr);

    //realizando conversão
}

void Conversor(int valueInput,double valueToConvert)
{
    if(valueToConvert <= 0)
    {
        Console.WriteLine("0 não pode ser convertido");
        return;
    }else
    {
        switch (valueInput)
        {
            case 1:
                Console.WriteLine($"{valueInput} em dolar equivale a {valueInput / 6,20} Reais");
                break;
            case 2:
                Console.WriteLine($"{valueInput} em Reais equivale a {
        }
    }
}



