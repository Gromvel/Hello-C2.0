﻿//  Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

{
    if (x > 0 && x < 8)
    {
        if (x == 7 || x == 6)
        {
            Console.Write("Под цифрой " + x + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + x + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
  
}