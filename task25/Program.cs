﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int value = 2;
for (int power = 0; power <= 4; power++)
   Console.WriteLine($"{value} в степени {power} = {(long)Math.Pow(value, power)} ");

