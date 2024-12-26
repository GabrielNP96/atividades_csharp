// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vamos descobrir se um número é primo!\nDigite um inteiro positivo: ");
string userNumber = Console.ReadLine()!;
int userNumberInteger = int.Parse(userNumber);

void IsAPrimeNumber(int number)
{
  
    if(number < 1) 
    {
        Console.WriteLine($"{number} não é primo");
        return;
    }

    for(int i = 2; i < Math.Sqrt(number); i++)
   {
     if (number % i == 0) 
            {
                Console.WriteLine($"{number} Não é um número primo");
                return; 
            }
        }
         Console.WriteLine($"{number} é um número primo");
   }

IsAPrimeNumber(userNumberInteger);



