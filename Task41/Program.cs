//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("Введите колличество вводимых чисел: ");
int M = int.Parse(Console.ReadLine());
int count = 0;
int []mass = new int[M];
for (int i = 0; i < M; i++)
{
    Console.WriteLine("Введите число: ");
    mass[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < M; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Колличество чисел больше 0 - {count}");