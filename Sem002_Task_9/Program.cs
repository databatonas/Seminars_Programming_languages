﻿/* Напишите программу. которая выводит случайное число из 
   отрезка [10,99] и показывает наибольшую цифру числа */

int N = new Random().Next(10,100);/* я хочу новое случайное целое число в диапозоне от 10 до 99. 
                                     по правилам 10 будет включено в диапазон, а 100 не будет включено */

Console.WriteLine(N);
int x = N/10;/*определяем первую цифру числа. так как у нас int- целое число, 
               то программа выдаст ближайшую слева цифру ( например: 75/10=7; 87/10=8; и.т.д.)*/
int y = N % 10;/*определяем вторую цифру числа. %10- остаток от деления числа на 10.( например: 75 % 10 = 5)*/

if(x > y)//если первая цифра (х) больше второй цифры (у), то
{
    Console.WriteLine(x);//выводим на экран (х)
}    
else//иначе
    {
     Console.WriteLine(y);//выводим на экран (у)   
    }
