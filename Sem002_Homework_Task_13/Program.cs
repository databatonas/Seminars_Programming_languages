﻿// Задача 13
/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
   что третьей цифры нет. Счет цифр ведется слева направо*/

Console.WriteLine("Введите число . При введении дробного числа используйте запятую");

 double a = Convert.ToDouble(Console.ReadLine());

//Первый блок
 if (a < 0)

 {
     a = a * -1;
 }

// Второй блок
if (a < 0.01 && a > 0)
{
    Console.WriteLine("Третья цифра" + " " + 0);
}

// Третий блок
if (a >= 0.01 && a < 10)
{
    a = a * 100;
    int b = (int)a;
    if (b % 10 == 0)
    {
        Console.WriteLine("Данное число не содержит третьей цифры.");
        return;
    }

    b = b % 10;
    Console.WriteLine("Третья цифра" + " " + b);
    return;
}

// Четвёртый блок
if (a >= 10 && a < 100)
{
    a = a * 10;
    int c = (int)a;
    if (c % 10 == 0)
    {
        Console.WriteLine("Данное число не содержит третьей цифры.");
        return;
    }
    c = c % 10;
    Console.WriteLine("Третья цифра" + " " + c);
}

// Пятый блок
while (a >= 1000)
{
    a = a / 10;
}
    if (a >= 100 && a < 1000)

    {
        int d = (int)a;
        d = d % 10;

        Console.WriteLine("Третья цифра" + " " + d);/* В ответ пойдет текст в кавычках. + -это для склейки строки. 
                                                       Кавычки с пробелом внутри-это пробел между текстом 
                                                       и значением переменной (b)*/ 
                                                                                                    
    }

//Шестой блок
if (a == 0)
{
    Console.WriteLine("Данное число равно нулю и  не может содержать третью цифру.");
 }

