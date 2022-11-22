//======= Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь (без массива)

/*

int GreaterThanZero(int quantity)
{
    int result = 0;

    for (int i = 1; i <= quantity; i++)
    {
        Console.Write($"Input number {i}: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0) result++;
    }

    return result;
}

Console.Write("How many numbers to check: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int result = GreaterThanZero(quantity);
Console.WriteLine(result);

*/

//======= Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// То ли задачи очень простые, то ли я что-то не так сделал...
// Посмотрел в интернете формулу поиска пересечений.
// Условие вывода сделал: либо пересекаются, либо нет, так как в задаче просят только пересечение.
// не совсем понял как формулы работают, по этому жаль что тест ответа только один был :(
// Надеюсь справился)

void IntersectionLines(double b1, double b2, double k1, double k2)
{

    if (b1 != b2 && k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Straight lines intersect: x = {x}; y = {y};");
    }
    else 
        Console.WriteLine("Straight lines don't intersect");
}

Console.Write("Input b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionLines(b1, b2, k1, k2);