﻿// Задача 18: 
// Напишите программу, которая по
// // заданному номеру четверти, 
// показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти:");

int quarter = Convert.ToInt32(Console.ReadLine());

string result = RangeCoordinates( quarter);

Console.WriteLine(result);

string RangeCoordinates(int coords)
{
if (coords == 1) return ("x > 0 , y > 0");
if (coords == 2) return ("x < 0 , y > 0");
if (coords == 3) return ("x < 0 , y < 0");
if (coords == 4) return ("x > 0 , y < 0");
return ("Не коректно введена четверть");
}