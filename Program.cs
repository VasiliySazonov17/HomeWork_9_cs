/*
Задача 54: Task54   
Задача 56: Task56
Задача 58: Task58
Задача 60: Task60
Задача 62: Task62

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

int[,] FillMatrix(int line, int columns)
{
    int[,] matrix = new int[line, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

int[,] SortDownLineMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int count = j;
            int indexMax = j;
            while (count < matrix.GetLength(1))
            {
                if (matrix[i, indexMax] < matrix[i, count])
                {
                    indexMax = count;
                }
                count++;
            }

            int numberMax = matrix[i, indexMax];
            matrix[i, indexMax] = matrix[i, j];
            matrix[i, j] = numberMax;

        }
    }

    return matrix;
}

int line = 3, columns = 15;
int[,] matrix = FillMatrix(line, columns);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(SortDownLineMatrix(matrix));



