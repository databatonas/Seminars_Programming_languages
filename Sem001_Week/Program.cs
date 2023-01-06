// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите целое число от 1 до 7 включительно");
int number = Convert.ToInt32(Console.ReadLine()); // 1 2 3 4 5 6 7

if(number == 1)
{
    Console.Write("Monday");
}

if(number == 2)
{
    Console.Write("Tuesday");
}

if(number == 3)
{
    Console.Write("Wednesday");
}

if(number == 4)
{
    Console.Write("Thusday");
}

if(number == 5)
{
    Console.Write("Friday");
}

if(number == 6)
{
    Console.Write("Saturday");
}

if(number == 7)
{
    Console.Write("Sunday");
}

if(number >7)
{
    Console.Write("You entered an incorrect number");
}

if(number <1)
{
    Console.Write("You entered an incorrect number");
}
