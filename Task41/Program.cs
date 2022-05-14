//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("Введите несколько чисел: ");
int M = int.Parse(Console.ReadLine());
int count = 0;
int []mass =new int[M];
if (M > 0)
{
    count++;
}
Console.WriteLine($"Колличество чисел больше 0 - {count}");