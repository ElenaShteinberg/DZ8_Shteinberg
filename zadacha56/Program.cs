// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumInString(int[,] array, int nowString)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[nowString, j];
    }
    return sum;
}

Console.Write("Создайте массив: укажите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns);

Console.WriteLine("Ваш массив:");
PrintArray(array);

int currentSum = 0;
int minSum = SumInString(array, 0); ;
int position = 0;
for (int i = 0; i < rows; i++)
{
    currentSum = SumInString(array, i);
    if (currentSum < minSum)
    {
        minSum = currentSum;
        position = i + 1;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов: " + position);