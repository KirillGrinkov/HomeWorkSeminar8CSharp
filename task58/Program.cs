//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Clear();


Console.Write("Введите количество строк первой матрицы: ");
int firstRows= int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов первой матрицы: ");
int firstColumns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество строк второй матрицы: ");
int secondRows= int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов второй матрицы: ");
int secondColumns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите минимальное значение матриц: ");
int minNum = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите максимальное значение матриц: ");
int maxNum = int.Parse(Console.ReadLine() ?? "");

int[,] firstMatrix = new int[firstRows,firstColumns];

int[,] secondMatrix = new int[secondRows,secondColumns];

int[,] productMatrix = firstMatrix;

Console.WriteLine();
Console.WriteLine();


FillMatrix(firstMatrix);
Console.WriteLine("Первая матрица");
PrintArray(firstMatrix);
Console.WriteLine();


FillMatrix(secondMatrix);
Console.WriteLine("Вторая матрица");
PrintArray(secondMatrix);
Console.WriteLine();


ProductOfMatrix(firstMatrix, secondMatrix, productMatrix);
Console.WriteLine("Произведение двух матриц");
PrintArray(productMatrix);




void FillMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minNum, maxNum);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}



void ProductOfMatrix(int[,] firstMatrix, int[,] secomdMatrix, int[,] productMatrix)
{
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
        int sum = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            sum += firstMatrix[i,k] * secondMatrix[k,j];
        }
        productMatrix[i,j] = sum;
    }
  }
}