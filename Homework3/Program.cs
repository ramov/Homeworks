// Задача 19: Напишите программу, которая принимает на вход пятизначное (а лучше любое) число и проверяет, является ли оно палиндромом.

// Не понимаю в чем ошибка... Почему в этом коде оба массива переворачиваются, когда переворачиваю только 1 и сравниваю их. Ниже решил задачу по другому.

/*

bool Palin(int number)
{
    if(number >= 11)
    {
        int x = number;
        int index = 0;

        while (x > 0)
        {
            x = x / 10;
            index++;
        }
        
        x = number;

        int[] array1 = new int[index];
        int[] array2 = new int[index];
        int iMax = array1.Length - 1;
        int iMin = 0;

        while(iMax >= iMin)
        {
            array1[iMax] = x % 10;
            x = x / 10;
            iMax--;
        }

        array2 = array1;
        iMax = array2.Length - 1;
        iMin = 0;
        int z = 0;

        while(iMax >= iMin)
        {
            z = array2[iMax];
            array2[iMax] = array2[iMin];
            array2[iMin] = z;

            iMin++;
            iMax--;
                
        }

        if(array1 == array2)
           return true;
        else
            return false;
    }   
    else 
        return false;
}

*/

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Palin(number));

/* 

// Понимаю, что лучше через string решить, потому что int не помещает в себя числа состоящие из более 10 цифры (методом проб и ошибок выяснил), но не понял как строку развернуть можно, а с double та же сама задача ошибку выдавала.
// без подсказки не решил бы...


bool Palin(int number) 
{
    if(number == 0) 
    {
        return true;
    }

    if(number < 0 || number % 10 == 0)
    {
        return false;
    }

    int temp = 0;
    int preNum = number;

    while (number > temp) 
    {
        int pop = number % 10;
        preNum = number;
        number = number / 10;
        temp = temp * 10 + pop;
    }
    if(number == temp || preNum == temp)
        return true; 
    else
        return false;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Palin(number));

*/

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

void Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    
    double k1 = x1 - x2;
    double k2 = y1 - y2;
    double k3 = z1 - z2;

    double k1_2 = Math.Pow(k1, 2);
    double k2_2 = Math.Pow(k2, 2);
    double k3_2 = Math.Pow(k3, 2);

    double g_2 = k1_2 + k2_2 + k3_2;
    double g = Math.Sqrt(g_2);

    Console.WriteLine(Math.Round(g, 2));
}


Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Distance(x1, x2, y1, y2, z1, z2);

*/

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

void Tabl(double num)
{
    double x = 1;
    while(x <= num)
    {
        Console.Write(Math.Pow(x, 3) + ", ");
        x++;
    }
}

Console.Write("Input number: ");
double num = Convert.ToDouble(Console.ReadLine());

Tabl(num);

*/