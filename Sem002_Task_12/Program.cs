//Задача 12
/* Напишите программу, которая на вход будет принимать два числа и выводить- 
   является ли первое число кратным второму. 
   Если первое число не кратно второму, то программа выводит остаток от деления.*/

Console.WriteLine("Введите первое число (используйте запятую при введении дробного числа)");
Console.ForegroundColor = ConsoleColor.Blue;
double a = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Введите второе число (используйте запятую при введении дробного числа)");
Console.ForegroundColor = ConsoleColor.Green;
double b = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;

if(b == 0)
{
Console.WriteLine("Вы ввели некорректно второе число- на ноль делить нельзя");
}

if (a < 0 && b > 0)
    {
        a = a * -1;
    }

if (a < 0 && b < 0)
{
    a = a * -1;
    b = b * -1;
    
    if (a > 0 && b > a)
    {
        Console.WriteLine("Вы ввели некорректное число - модуль второго числа должен быть меньше модуля первого числа");
    }
}
if (a % b == 0)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Первое число кратно второму");
}

if (a % b != 0 && a > b)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Остаток от деления {a % b}");
}


