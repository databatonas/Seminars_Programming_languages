// Задача 16
/* Напишите программу, которая принимает на вход два числа и проверяет, 
   является ли одно число квадратом другого*/


Console.WriteLine("Введите первое число (используйте запятую при введении дробного числа)");
Console.ForegroundColor = ConsoleColor.Blue;
double a = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Введите второе число (используйте запятую при введении дробного числа)");
Console.ForegroundColor = ConsoleColor.Green;
double b = Convert.ToDouble(Console.ReadLine());

if (a == b * b || b == a * a)/* если (а) является квадратом(b) или (b) является квадратом (а), то ...*/
{
    Console.WriteLine("Одно число является квадратом другого числа");
}

else // иначе...
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}