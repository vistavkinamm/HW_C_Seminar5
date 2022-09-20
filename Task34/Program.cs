// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int []array=new int [6];
int size=array.Length;

int numEven=0;

for (int i=0; i<size; i++)
{
    array[i]=new Random().Next (100, 1000);

    if (array[i]%2==0)
    {
        numEven+=1;
    }
}

Console.WriteLine(String.Join("," , array));
Console.WriteLine("В заданном массиве колличество четных чисел = " + numEven);
