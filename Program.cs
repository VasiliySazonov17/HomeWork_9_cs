/*
Задача 54: Task54   
Задача 56: Task56
Задача 58: Task58
Задача 60: Task60
Задача 62: Task62

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

/*int[] array1 = new int[] { 1, 2, 3 };

int[] array2 = new int[] { 5, 4, 3 };

int[] array3 = new int[array1.Length];
int value = 0;
for (int i = 0; i < array1.Length; i++)
{
    value += array1[i] * array2[i];

}
Console.WriteLine(value);*/

int[,] TransposedMatrix(int[,] matrix)
{
    int[,] resultMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultMatrix[j, i] = matrix[i, j];
        }
        Console.WriteLine();
    }
    return resultMatrix;
}


void MultiplicationTwoMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[] arrayValueMultiplic = new int[firstMatrix.GetLength(0) * secondMatrix.GetLength(1)];
    secondMatrix = TransposedMatrix(secondMatrix);
    int count = 0;
    int sumValue = 0;
    int line = 0;
    int columns = 0;

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        while (line < secondMatrix.GetLength(0))
        {
            for (int j = 0; j < firstMatrix.GetLength(1); j++)
            {
                sumValue += firstMatrix[i, j] * secondMatrix[line, columns];
                columns++;
            }
            arrayValueMultiplic[count] = sumValue;
            count++;
            sumValue = 0;
            columns = 0;
            line++;
        }
        line = 0;
    }
    count = 0;
    for (int k = 0; k < arrayValueMultiplic.Length; k++)
    {
        Console.Write($"{arrayValueMultiplic[k]} ");
        count++;
        if (count == arrayValueMultiplic.Length / 3)
        {
            Console.WriteLine();
            count = 0;
        }
    }
}

int line = 3, columns = 3;
int[,] firstMatrix = FillMatrix(line, columns);
line = 3; columns = 2;
int[,] secondMatrix = FillMatrix(line, columns);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
MultiplicationTwoMatrix(firstMatrix, secondMatrix);