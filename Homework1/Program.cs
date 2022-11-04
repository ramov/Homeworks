// Задача №1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


/*

Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber == secondNumber)
    Console.Write("The first and second numbers are equal");

if(firstNumber > secondNumber)
    Console.Write("The first number is greater than the second");

if(firstNumber < secondNumber)
    Console.Write("The second number is greater than the first");

*/


// Задача №2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


/*

Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = thirdNumber;

if(max < firstNumber)
    max = firstNumber;

if(max < secondNumber)
    max = secondNumber;

if(max == firstNumber || firstNumber == secondNumber)
    Console.WriteLine("The numbers are equal");

Console.Write($"The maximum number is {max}");

*/


// Задача №3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


/*

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 2;

if(result == 0)
    Console.Write($"{number} this is an even number");
else
    Console.Write($"{number} this is an odd number");

*/


// Задача №4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


/*

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int currentPlus = 2;
int currentMinus = -2;

if(number >= currentPlus)
{
    while(currentPlus <= number)
    {
        Console.Write($"{currentPlus}, ");
        currentPlus = currentPlus + 2;
    }
}

if(number <= currentMinus)
{
    while(currentMinus >= number)
    {
        Console.Write($"{currentMinus}, ");
        currentMinus = currentMinus - 2;
    }
}

*/