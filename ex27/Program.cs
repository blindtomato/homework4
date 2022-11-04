//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

int SumNum(int number)
{
    number = Math.Abs(number);
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {num} равна {SumNum(num)}.");