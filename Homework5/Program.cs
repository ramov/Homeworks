//====== Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void ShowArray(int[] array) // эту функцию использовать не обязательно, как я понял, но для облегчения проверки решил оставить в первой задаче.
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

/*

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);

    return array;
}

void EvenNum(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            result++;

    Console.Write($"the number of even numbers in the array: {result}");
}

Console.Write("Input a number of elements: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(sizeArray);
ShowArray(array); 
EvenNum(array);

*/

//====== Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array;
}

/*

void SumOddArrayElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum = sum + array[i];

    Console.Write("Sum of odd array elements: " + sum);
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(n, min, max);
ShowArray(array);
SumOddArrayElements(array);

*/

//====== Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void DiffMinMax(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) 
            min = array[i];
        else if (array[i] > max)
            max = array[i];

    int result = max - min;
    Console.Write($"Difference between {min} and {max}: {result} ");
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(n, min, max);
ShowArray(array);
DiffMinMax(array);