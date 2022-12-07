// Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray()
{
    int[,] array = new int[4, 4];
    int number = 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = number;
        number++;
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, 3] = number;
        number++;
    }
    for (int j = 2; j >= 0; j--)
    {
        array[3, j] = number;
        number++;
    }
    for (int i = 2; i >= 1; i--)
    {
        array[i, 0] = number;
        number++;
    }
    for (int j = 1; j <= 2; j++)
    {
        array[1, j] = number;
        number++;
    }
    for (int j = 2; j >= 1; j--)
    {
        array[2, j] = number;
        number++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray();

Console.WriteLine("Ваш массив:");
PrintArray(array);