//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке..
// Далее надо посчитать количество нулей и единиц, если единиц больше 
//чем нулей то вывести TRUE на экран, иначе вывести False.

int[] fillArray(int lenght)
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

bool Is1MuchThan0(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == 1)
            count++;
    }
    return count > array.Length - count;      
}

int[] newArray = fillArray(8);
printArray(newArray);
Console.WriteLine(Is1MuchThan0(newArray));