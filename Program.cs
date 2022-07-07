/*
Задача 54: Task54   
Задача 56: Task56
Задача 58: Task58
Задача 60: Task60
Задача 62: Task62

Задача 62: Заполните спирально массив 4 на 4.

*/

Console.Write("Input size matrix: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
int value = 1, i = 0, j = 0;
Console.WriteLine();
while (value <= size * size)
{
    matrix[i, j] = value;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    value++;
}
PrintMatrix(matrix);



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