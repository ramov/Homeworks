//======= Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

*/

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


/*

void ArrayOrdered(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1); k++)
            {
                int temp = 0;

                if (array[i, j] > array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
}

*/

// Console.Write("input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// ArrayOrdered(myArray);
// Show2dArray(myArray);


//======= Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*

void SmallestRow(int[,] array)
{
    int minI = 0;
    int minSum = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];

        if (sum < minSum)
        {
            minSum = sum;
            minI = i;
        }
    }
    Console.WriteLine($"Smallest row: {minI + 1}");
}

SmallestRow(myArray);

*/

//======= Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

/*

void ProductOfMatrices(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array2.GetLength(1); j++)
                for (int k = 0; k < array2.GetLength(0); k++)
                    result[i, j] += array1[i, k] * array2[k, j];

        Show2dArray(result);
    }
    else Console.WriteLine("Error");
}

Console.Write("input a number of rows: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray2 = CreateRandom2dArray(m2, n2, min2, max2);
Show2dArray(myArray2);
ProductOfMatrices(myArray, myArray2);

*/

//======== Задача 60: 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Попробовал решить для любых чисел, но так и не понял как в функции CreateUniqueRandom3dArray 
// вывести else c описанием ошибки, когда чисел уникальных меньше размера массива, при условии, что функция выводит интовый массив.
// ПОтом уже посмотрел, что можно использовать переменные типа Random, но не до конца изучил, как этот тип работает...
// Да и не понятно, можно ли использовать информацию из гугла для ДЗ...

/*

int UniqueNumber3dArray(int[,,] array)
{
    int num = new Random().Next(10, 101);

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (num == array[i, j, k])
                    UniqueNumber3dArray(array);

    return num;
}

int[,,] CreateUniqueRandom3dArray(int rows, int columns, int depth)
{
        int[,,] array = new int[rows, columns, depth];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                for (int k = 0; k < depth; k++)
                    array[i, j, k] = UniqueNumber3dArray(array);
        
        return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($" {array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a depth of array: ");
int h = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateUniqueRandom3dArray(m, n, h);
Show3dArray(myArray);

*/

//======== Задача 62: 
// Напишите программу, которая заполнит спирально массив 4 на 4 (заполняет массив любого размера)

int[,] CreateSpiral2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int current = 1;
    int min = 0;

    for (int i = min; i < rows; i++)
    {
        for (int j = min; j < columns; j++) // заполняем вправо
        {
            array[i, j] = current;
            current++;

            if (j == columns - 1) 
                for (int k = i + 1; k < rows; k++) // заполняем вниз
                {
                    array[k, j] = current;
                    current++;

                    if (k == rows - 1)
                        for (int l = j - 1; l >= min; l--) // заполняем влево 
                        {
                            array[k, l] = current;
                            current++;

                            if (l == min)
                                for (int m = k - 1; m > min; m--) // заполняем вверх
                                {
                                    array[m, l] = current;
                                    current++;
                                }
                        }
                }
        }

        rows--; columns--; min++;
    }

    return array;
}

Console.Write("input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSpiral2dArray(m, n);
Show2dArray(myArray);