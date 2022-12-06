//========= Задача 64:
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

/*

void ShouNums(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShouNums(num - 1);
}

ShouNums(10);

*/

//========= Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*

int SumNumbersFromTo(int m, int n)
{
    if (m < n) return SumNumbersFromTo(m + 1, n) + m;
    else if (m > n) return SumNumbersFromTo(m - 1, n) + m;
    return m;
}

Console.Write(SumNumbersFromTo(4, 8));

*/

//========= Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return Ackerman(m, n);
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"A({m},{n}) = {Ackerman(m, n)}");
