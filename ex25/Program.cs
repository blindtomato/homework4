//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Pow(int baseOfDegree, int indicator)
{
    int result = 1;
    for(int i = 1; i<= indicator; i++)
        result = result * baseOfDegree;
    return result;
}

Console.WriteLine("Введите число, которое будет использоваться в качестве основания степени");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите натуральное число, которое будет использоваться в качестве показателя степени");
int num2 = Convert.ToInt32 (Console.ReadLine());

if (num2 <= 0)
    Console.WriteLine("Вы ввели некорректное число");
else
    Console.WriteLine($"{num1} в степени {num2} равно {Pow(num1, num2)}.");