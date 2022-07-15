//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int AkkermanFunction (int NumberM, int NumberN)
{
    if (NumberM == 0)
    {
       return NumberN + 1;
    }
    else
    {
        if (NumberN ==0)
        {
             return AkkermanFunction (NumberM-1, 1);

        }
         else
         {
             return AkkermanFunction (NumberM-1, AkkermanFunction(NumberM,NumberN-1));
         }
    }
}

int NumberM = Prompt("Введите 1 неотрицательное число: ");
int NumberN = Prompt("Введите 2 неотрицательное число: ");
System.Console.WriteLine($"A({NumberM},{NumberN}) = {AkkermanFunction(NumberM,NumberN)}");

