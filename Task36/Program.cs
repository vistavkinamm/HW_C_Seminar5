﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int []array=new int[6];
int size=array.Length;

int negativeSum=0;

for (int i=0; i<size; i++)
{
    array[i]=new Random().Next(-99, 100);

    if (i % 2 == 1)
    {
        negativeSum =array[i]+negativeSum;
    }
}

Console.WriteLine(string.Join(",", array));
Console.WriteLine("Сумма элементов нечетных позиций = " + negativeSum);
