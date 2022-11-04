/*

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Не совсем понял, нужна ли проверка на трехзначное число. Провозился несколько часов, но вроде получилось)))) Опять фигурные скобки запутали...
// Ниже 2 варианта, с рандомными числами и с числами введенными пользователем.

int Num2(int num)
{   
    num = num / 10;
    num = num % 10;
    return num;
}       

int number = new Random().Next(1, 9999);
Console.WriteLine(number);

// Console.Write("Input three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

if (number > 999 || number < 100)
{
    while (number > 999 || number < 100)
    {
        number = new Random().Next(1, 9999);
        Console.WriteLine(number);
        
        // Console.Write("Input three-digit number: ");
        // number = Convert.ToInt32(Console.ReadLine());
    }
}

int result = Num2(number);
Console.WriteLine($"{number} this is a three digit number, and its second digit = {result}.");

*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


/*

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    if (num / 100 > 0)
    {
        while (num / 1000 > 0)
        {
            num = num / 10;
        }    
            num = num % 10; 
            return num;
    }   
    else 
        num = -1;
        return num;
}

int result = ThirdDigit(number);
if (result >= 0)
    Console.WriteLine($"The third digit of the number {number} = {result}");
else 
    Console.WriteLine($"the third digit of the number {number} is missing");

*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Простая задачка. Решил усложнить и добавить проверки на число больше или меньше дней в неделе + разный выод текста при определенных условиях.

/*
bool Weekend(int number)
{
    if (number == 6 || number == 7)
        return true;
    else
        return false;
}


Console.Write("Input the number of the day of the week: ");
int random = Convert.ToInt32(Console.ReadLine());

//int random = new Random.Next(1, 8);
//Console.WriteLine(random);

bool result = Weekend(random);

if (result == true)
    Console.WriteLine($"{random} day of the week is a weekend");

if (result == false && random <= 7 && random >= 1)
    Console.WriteLine($"{random} day of the week is not a weekend");

if (result == false && random > 7 || random < 1) 
    Console.WriteLine($"There are 7 days in a week. Enter a number not exceeding 7");

*/


// Решил попробовать создать функцию с полным циклом проверок внутри. Получилось длинно, но вроде получилось)))
// Думаю можно еще и через массив решить, но и так мног овремени потратил, так что не буду.

/*

int Weekend(int number)
{
    int result = -1;

    if (number >= 1 && number <= 7)
    {
        bool WeekendTrFl(int number)
        {
            if (number == 6 || number == 7)
                return true;
            else
                return false;
        }
        
        bool tr_fl = WeekendTrFl(number);

        if (tr_fl == true)
            result = 1;

        if (tr_fl == false && number <= 7 && number >= 1)
            result = 2;
    }    
    
    return result;

}

Console.Write("Input the number of the day of the week: ");
int random = Convert.ToInt32(Console.ReadLine());

//int random = new Random.Next(1, 8);
//Console.WriteLine(random);

int result = Weekend(random);

if (result == 1)
    Console.WriteLine($"{random} day of the week is a weekend");

if (result == 2)
    Console.WriteLine($"{random} day of the week is not a weekend");

if (result == -1) 
    Console.WriteLine($"There are 7 days in a week. Enter a number not exceeding 7");

*/