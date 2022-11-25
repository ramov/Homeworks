//======== Задача 47:
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = Math.Round(new Random().Next(minValue, maxValue + 1)
//                 + new Random().NextDouble(), 2);

//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

/*

Console.Write("input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

*/


//========= Задача 50: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

/*

string ElementSearch(int row, int column, double[,] array)
{
    if (row < array.GetLength(0)
        && row >= 0
            && column < array.GetLength(1)
                && column >= 0)
    {
        return Convert.ToString(array[row, column]);
    }
    else return "There is no such element";
}

Console.Write("Enter the line number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column number: ");
int column = Convert.ToInt32(Console.ReadLine());

string result = ElementSearch(row, column, myArray);
Console.WriteLine(result);

*/

//========= Задача 52: 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void ArithmeticMeanByColumns(int[,] array)
{
    double sum = 0;
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.Write($"{sum / array.GetLength(0)} ");
        sum = 0;
    }
}

Console.Write("input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
ArithmeticMeanByColumns(myArray);