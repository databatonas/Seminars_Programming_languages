﻿// Задача 10
/* Напишите программу, которая на вход принимает трёхзначное число
   и на выходе показывает вторую цифру этого числа*/

Console.WriteLine("Введите трёхзначное число.");
Console.WriteLine("При введении дробного числа будет  учитываться только целая часть числа");

double c = Convert.ToDouble(Console.ReadLine());

int a = (int)c;/* Переменной (i) присвоить только целую часть переменной(b)*/
Console.WriteLine(a);

if (a > -99 && a < 100 || a > 999 || a <-999) /* если (а) больше -99 или больше 999 или меньше -999, то...*/
{
    Console.WriteLine("Вы ввели некорректные данные. Введите трёхзначное число");
    return;/* Это нужно для того, чтобы отображался в консоли только один ответ,
              иначе будет отображаться и ответ с поиском второй цифры*/
}

if (a < -99)
{
    a = a * -1;
}

int b = (a % 100) / 10;/* Переменной (b) присвоим значение переменной(а), 
                          делённой с остатком на 100 (при этом в остатке будут вторая и третья цифры) 
                          и делённой на 10 ( при этом останется только вторая цифра, 
                          которая и пойдет в ответ) */

Console.WriteLine("Вторая цифра" + " " + b);

