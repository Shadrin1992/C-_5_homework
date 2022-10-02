// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{   
   array[i] = rand.Next(-50, 51);
}

int max = array[0];
int min = array[0];

for(int i = 1; i < array.Length; i++)
{
    if(array[i]>max)
    {
        max = array[i];
    }
    if(array[i]<min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Разница между max/min значением равна: {max-min}");
var str = string.Join(" ", array);
Console.WriteLine(str);