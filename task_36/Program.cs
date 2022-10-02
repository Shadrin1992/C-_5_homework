﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{   
   array[i] = rand.Next(-100, 101);
}

int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    if(i%2 != 0)
    {
     sum = sum + array[i];
    }
}
Console.WriteLine($"Сумма чисел с нечетными индексами:  {sum}");
var str = string.Join(" ", array);
Console.WriteLine(str);