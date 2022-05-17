﻿//Задача 43. Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями y = k1 *x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
Console.Write("Введите значение b1, k1, b2, k2: ");
double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;
x = Math.Round(x,1); 
y = Math.Round(y,1);
Console.WriteLine($"Точка пересечения имеет координаты: ({x};{y})");