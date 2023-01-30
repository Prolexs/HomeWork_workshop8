//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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


void SortToLower(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
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
SortToLower(arr);
Console.WriteLine();
PrintArray(arr);