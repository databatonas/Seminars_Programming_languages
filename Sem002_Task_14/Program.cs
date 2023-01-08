// Задача 14
 /*Напишите программу, которая принимает на вход число 
   и проверяет, кратно ли оно одновременно 7 и 23.*/

Console.WriteLine("Введите число (используйте запятую при введении дробного числа)");
Console.ForegroundColor = ConsoleColor.Blue;
double a = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;

if(a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($"{a} кратно и 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"{a} не кратно и 7 и 23 одновременно");
}