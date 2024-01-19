string? readResult;
bool validEntry = false;
int parsedInt = 0;
Console.WriteLine("Entre com um número entre 5 e 10: ");
do
{
    readResult = Console.ReadLine();

    bool validNumber = int.TryParse(readResult, out parsedInt);

    if (validNumber)
    {
        if ((parsedInt > 5) && (parsedInt < 10))
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine($"O {parsedInt} não está entre 5 e 10! Tente novamente.");
        }
    }
    else
    {
        Console.WriteLine("Você digitou um número inválido! Tente novamente.");
    }


} while (validEntry == false);
Console.WriteLine($"O {parsedInt} é válido!");


