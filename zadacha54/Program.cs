// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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


void StringSorting(int[,] array, int nowString)
{
    int max = 0;
    int positionMax = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            if (array[nowString, j] > max)
            {
                max = array[nowString, j];
                positionMax = j;
            }
        }
        array[nowString, positionMax] = array[nowString, i];
        array[nowString, i] = max;
        max = 0;
    }
}


Console.Write("Создайте массив: укажите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns);

Console.WriteLine("Ваш массив:");
PrintArray(array);

int nowString = 0;
for (int i = 0; i < rows; i++)
{
    StringSorting(array, nowString);
    nowString++;
}

Console.WriteLine("Упорядоченный массив:");
PrintArray(array);
