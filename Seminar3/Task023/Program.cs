﻿// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); 

// int i = 1; - начало: задаем старт с 1 (как в условии задачи),
// i <= N; - условие для цикла, 
// i++ - увеличение счетчика на 1 
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"Результат: {i*i*i}"); // интерполяция
}

