// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateFillArray()

{
    Console.WriteLine("Введите количество строк и столбцов в таблице (ввод числа через enter): ");
    int[,] arr = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Random.Shared.Next(10);
            Console.Write($"|{arr[i, j],2} | ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[] GetSumLine(int[,] array)

{
    int[] arrSum = new int[array.GetLength(0)];
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrSum[i] = sum += array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки равна {arrSum[i]}");
        sum = 0;
    }
    Console.WriteLine();
    return arrSum;
}
int MinValueArray(int[] collection)
{
    int line = 0;
    int min = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (min > collection[i])
        {
            min = collection[i];
            line = i;
        }
    }
    return min;
}
void CheckMinValueAndPrint(int minValue, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (minValue == array[i])
        {
            Console.WriteLine($"Строка № {i + 1} имеет наименьшее значение равное {minValue}");
        }
    }
}
int[,] arr = CreateFillArray();
int[] arrSum = GetSumLine(arr);
int min = MinValueArray(arrSum);
CheckMinValueAndPrint(min, arrSum);
