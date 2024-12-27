// Converter uma quantidade de dinheiro de uma moeda para outra.
Console.WriteLine("Bem vindo ao Conversor de Moedas");
bool i = true;
while(i != false)
{
    //recebendo dados
    Console.WriteLine(@"Digite o númeral referente a moeda original: 
                        1 - Dollar
                        2 - Real
                        3 - Euro
                        4 - Libra Esterlina");
    string inputOptionStr = Console.ReadLine()!;
    
    Console.WriteLine(@"Digite o númeral referente a moeda a ser convertida: 
                        1 - Dollar
                        2 - Real
                        3 - Euro
                        4 - Libra Esterlina");
    string exitOptionStr = Console.ReadLine()!;

    //convertendo dados
    int inputOption = int.Parse(inputOptionStr);
    int exitOption = int.Parse(exitOptionStr);
}

