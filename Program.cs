// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int[,] GenerateArray(int rows, int cols)
{
    int[,] arrayD2 = new int[rows, cols];
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = new Random().Next(0, 10);
        }
    }
    return arrayD2;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void GetMinSumLine(int[,] numbers)
{
    int[] sumInLines = new int[numbers.GetLength(0)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sumInLines[i] += numbers[i, j];
        }
    }
    int minI = 0;
    for (int i = 0; i < sumInLines.Length; i++)
    {
        if (sumInLines[minI] > sumInLines[i]) minI = i;
    }
    Console.Write($"{minI + 1} - строка с наименьшей суммой элементов, равной {sumInLines[minI]}");
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
int[,] arr = GenerateArray(rows, columns);
ShowArray(arr);
GetMinSumLine(arr);