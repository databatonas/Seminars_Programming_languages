// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от (-N) до (N).

int n = 0;
Console.WriteLine("Введите число N");
n = Convert.ToInt32(Console.ReadLine());

for (int i = -n; i <= n; i++)
{
    Console.Write( i + " ");
}
