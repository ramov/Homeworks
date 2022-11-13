//======== Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// Закоментил ниже попытку сделать полноценную программу возводящую в степень все числа, но не могу понять в чем ошибка при минусовой степени.
// прокомментировал и закоментил код ниже.

/*

double Degree(double a, double b)
{
    if (a > 0 || a < 0)
    {
        if (b > 0)
        {
            double result = a;
            for (double i = 1; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        else if (b == 0) return 1;

        else           
            return -1;   
        // {
        //     double result = a;
        //     for (double i = 0; i >= b; i--)
        //     {
        //         result = 1 / a;   // делает 1 шаг и останавливается. Тестил на числах 5, -3 и -5, -3 всегда выдает 0,2 или -0,2
        //     }                     // пробовал менять i, отношения i к b, инкремент и дискремент ставил так же ничего не меняется
        //     return result;
        // }
    }
    else
        return 0;

}

Console.Write("Input number A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Input number B: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{a} to the degre {b} = {Degree(a, b)}");

*/

//======== Задача 27: 
// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

/*

int Sum(int number)
{
    int sum = 0;
    int current = 0;

    if (number < 0)
        number *= -1;

    while (number > 0)
    {
        current = number % 10;
        number /= 10;
        sum = sum + current;
    }
    return sum;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"the sum of the digits of the number {number} = {Sum(number)}");

*/

//======== Задача 29: 
// Напишите программу, которая принимает на вход массив из m элементов и 
// выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    int number = 0;

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input number: ");
        number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Enter size of array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(n);
ShowArray(myArray);