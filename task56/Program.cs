// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите минимальное значение массива: ");
int minNum = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите максимальное значение массива: ");
int maxNum = int.Parse(Console.ReadLine() ?? "");

int[,] array = new int[rows, columns];

GetRandomArray(array);

PrintArray(array);

Console.WriteLine();

FindMinSumRows(array);


void GetRandomArray (int[,] array)
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


int SumRows(int[,] array, int i)
{
    int sumRows = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
        sumRows = sumRows + array[i,j];
        Console.WriteLine(sumRows);
    return sumRows;
}

void FindMinSumRows(int[,] array)
{
    int minSumLine = 0;
int sumLine = SumRows(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumRows(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"\n Строка № {minSumLine+1} с меньшей суммой элемнов  ");
}

