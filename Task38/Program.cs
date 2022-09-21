// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



double[] array = new double[20];
Random rand = new Random();
int size=array.Length;
double numMax=Int32.MinValue;
double numMin=Int32.MaxValue;
for (int i = 0; i < size; i++)
{
array[i] = Convert.ToDouble(new Random().Next(100,1000));

    if ( array[i]>numMax)
    {
        numMax=array[i];
    }
    if (array[i]<numMin)
    {
        numMin=array[i];
    }
    
}
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Максимальное значение = {numMax}, минимальное значение = {numMin}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {numMax - numMin}");
