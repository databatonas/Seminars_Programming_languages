﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

Console.WriteLine("Введите число a (используйте запятую при введении дробного числа)");
double a = Convert.ToDouble(Console.ReadLine()); /*оператор double дает возможность вводить дробные числа*/

if (a % 2 == 0)                                  /* если а делится на два без остатка (четное), то */
{
    Console.Write($"{a} чётное число");          /* данная запись дает возможность выводить в консоль
                                                    значение переменной а и текст */
}
else                                             /* иначе */
{
    Console.Write($"{a} нечётное");
}
