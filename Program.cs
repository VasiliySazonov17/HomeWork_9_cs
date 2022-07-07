/*
Задача 54: Task54   
Задача 56: Task56
Задача 58: Task58
Задача 60: Task60
Задача 62: Task62

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int[,] FillMatrix(int line, int columns)
{
    int[,] matrix = new int[line, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 18);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}

int FindMinSumLine(int[,] matrix)
{
    int[] sumLineArray = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumLineArray[i] += matrix[i, j];
        }
    }

    int minSumNumbers = 0;
    for (int k = 0; k < sumLineArray.Length; k++)
    {
        if (sumLineArray[k] < sumLineArray[minSumNumbers])
        {
            minSumNumbers = k;
        }
    }
    Console.WriteLine($"Minimum sum of elements in {minSumNumbers} line ");
    return minSumNumbers;
}





int line = 3, columns = 4;
int[,] matrix = FillMatrix(line, columns);
PrintMatrix(matrix);
FindMinSumLine(matrix);
