/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

 int GetNumber(string message)
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

int DigitSumm(int number)
{
    int result = 0;
    while (number > 0)
    {
     result += number % 10;
     number = number / 10;
    }

    return result;
}

int number = GetNumber("Введите число:");
Console.WriteLine($"Cумма цифр в числе рована:{DigitSumm(number)}");