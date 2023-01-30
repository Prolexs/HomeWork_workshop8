// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Задайте колл-во строк");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте колл-во столбцов");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] arr = new int[x, y];
Random rand = new Random();

void FillArrayRandom(int[,] arr)
{


    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rand.Next(1, 9);
    }
}


void RowMinSumElements(int[,] arr)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minRow += arr[0, i];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
         sumRow += arr[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($" строка с наименьшей суммой элементов под номером {minSumRow + 1} ");
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArrayRandom(arr);
PrintArray(arr);
RowMinSumElements(arr);
Console.WriteLine();
PrintArray(arr);