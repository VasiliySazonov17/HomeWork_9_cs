/*
Задача 54: Task54   
Задача 56: Task56
Задача 58: Task58
Задача 60: Task60
Задача 62: Task62

Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
Console.Write("Input quantity lines matrix: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity columns matrix: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity surfaces matrix: ");
int surfaces = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

PrintMatrix3D(FillMatrix3D(lines, columns, surfaces));





int[,,] FillMatrix3D(int lines, int columns, int surfaces)
{
    int[,,] matrix3D = new int[lines, columns, surfaces];

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)

        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = CheckRepeatNumbers(matrix3D, new Random().Next(10, 99));
            }
        }
    }

    return matrix3D;
}


int CheckRepeatNumbers(int[,,] matrix, int number)
{
    int count = 1;
    while (count != 0)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)

            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    if (matrix[i, j, k] == number)
                    {
                        number = new Random().Next(10, 99);
                        count++;
                    }
                }
            }
        }
        count--;
    }
    return number;
}

void PrintMatrix3D(int[,,] matrix)
{

    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)

        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

    }
}