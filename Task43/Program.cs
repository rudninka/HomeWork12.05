﻿//Задача 43. Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями y = k1 *x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
Console.Write("Введите значение b1, k1, b2, k2: ");
int b1 = int.Parse(Console.ReadLine());
int k1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
{
    Console.Write("Прямые не пересекутся");
}
 