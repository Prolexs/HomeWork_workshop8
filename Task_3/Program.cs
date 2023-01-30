// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Задайте колл-во строк");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте колл-во столбцов");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] arr = new int[x, y];
int[,] secondArr = new int[x, y];
int[,] resultArr = new int[x, y];
Random rand = new Random();

void FillArrayRandom(int[,] arr)
{


    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rand.Next(1, 9);
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

Console.WriteLine();

FillArrayRandom(secondArr);
PrintArray(secondArr);

Console.WriteLine();

if (arr.GetLength(0) != secondArr.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < secondArr.GetLength(1); j++)
    {
        resultArr[i, j] = 0;
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            resultArr[i, j] += arr[i, k] * secondArr[k, j];
        }
    }
}

PrintArray(resultArr);