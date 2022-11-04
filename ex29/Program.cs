//Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

int[] fillArray(int lenght)
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToInt32 (Console.ReadLine());
    }
    return array;
}

void printArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

printArray(fillArray(8));
