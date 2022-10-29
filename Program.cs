/*Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива. 
[3 7 22 2 78] -> 76*/


Console.WriteLine("Введите число - размер массива");
int num = int.Parse(Console.ReadLine()!);
int[] RandomArray()
{
    int[] array = new int[num];
    Random rnd = new Random();

    for (int i = 0; i < num; i++)
        array[i] = rnd.Next(1,100);

    return array;
}
//создаем массив из случайных  чисел  

void PrintArray(int[] array)
{

    for (int i = 0; i < num; i++)
        Console.Write($"{array[i]} ");
}
// напечатать массив

int DiffMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < num; i++)
        if (array[i]>max)
            max=array[i];
    return max;
}
//ищщем максимальное число в массиве
int DiffMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < num; i++)
        if (array[i]<min)
            min=array[i];
    return min;
}

//ищщем минимальное число в массиве

int[] array = RandomArray();
PrintArray(array);
Console.WriteLine("");
int max = DiffMax(array);
int min = DiffMin(array);
Console.WriteLine($"максимум -> {max},минимум -> {min}");
Console.WriteLine($"разница {max - min}");