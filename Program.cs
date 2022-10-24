// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int GetSecondDigit(int num)
{
    int ed = num / 10;
    int dec = ed % 10;
    return dec;
}

Console.WriteLine("Введите трехзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());
if (num > 1000 || num < 100)
{
    Console.WriteLine("Ошибка: некорректное число!");
}
else 
{
   int result = GetSecondDigit(num);
    Console.WriteLine(result); 
}
*/



/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*string IsWeekEnd(int num)
{
    if (num < 1 || num > 7) 
    {
        return "Ошибка: некорректный день недели!";
    }
    else 
    {        
        if (num >=1 && num <= 5)
            return "нет";
        else return "да";
    }
}

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = IsWeekEnd(num);
Console.WriteLine(result);
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int GetThirdDigit(int num) 
{
    // считаем количество разрядов
    int tmp = num;
    int counter = 1;
    while ((tmp > 1000))
    {
        tmp /= 10;
        counter++;
    }
    return  tmp % 10;
;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
    int result = GetThirdDigit(num);
    Console.WriteLine(result);
}
*/