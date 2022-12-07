// Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] finalArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                finalArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return finalArray;
}

Console.Write("Создайте первый массив: укажите кол-во строк: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = FillArray(rows1, columns1);

Console.Write("Создайте второй массив: укажите кол-во строк: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = FillArray(rows2, columns2);

Console.WriteLine("Первая матрица:");
PrintArray(array1);
Console.WriteLine("Вторая матрица:");
PrintArray(array2);

if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Невозможно найти произведение матриц");
}
else
{
    Console.WriteLine("Произведение матриц:");
    PrintArray(MatrixMultiplication(array1, array2));
}
