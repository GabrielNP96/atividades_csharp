//Criar um jogo onde o computador escolhe um número aleatório e o usuário tenta adivinhá-lo.
//Gerando número aléatorio
Random random = new Random();
int randomNumber = random.Next(1, 101);

//Recebendo um número do usuario
Console.WriteLine("Vamos brincar de adivinhar um número entre 1 e 100 você tem 10 chances!");

int i = 10;
while(i > 0) 
{
    Console.Write("Digite um número de 0 a 100: ");
    string userNumberStr = Console.ReadLine()!;
    int userNumber = int.Parse(userNumberStr);


//começando o jogo
    if (userNumber == randomNumber)
    {
        Console.WriteLine("Parabéns você acertou!");
        break;
    } else if (userNumber < randomNumber)
    {
        Console.Clear();
        i--;
        Console.WriteLine($"Você errou, mas {userNumber} é menor que o número secreto!\nVocê tem {i} chances");
    } else if (userNumber > randomNumber)
    {
        i--;
        Console.WriteLine($"Você errou, mas {userNumber} é maior que o número secreto!\nVocê tem {i} chances");
    } else
    {
        Console.Clear();
        Console.WriteLine("Algo deu Errado...");
    }
}
