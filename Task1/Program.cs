/* Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
 
 int GetNumberA(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
        break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Повторите ввод");
        }
    }
    return result;
}

int GetNumberB(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
        break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Повторите ввод");
        }
    }
    return result;
}

int GetResult(int numberA, int numberB)
{
 int result = 1;

    for (int i = 0; i < numberB; i++)
    {
    result *= numberA;
    }

return result;
}

int numberA = GetNumberA("Введите число А:");
int numberB = GetNumberB("Введите число B:");
int result = GetResult(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");