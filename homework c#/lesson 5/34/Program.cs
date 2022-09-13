// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}
int EvenNumbers(int[] arr)
{
    int sum = 0;
    foreach (int value in arr)
    {
        sum += value % 2 == 0 ? 1 : 0;
    }
    return sum;
}

int[] array = GetArray(10, 100, 1000);
PrintArray(array);
Console.WriteLine(EvenNumbers(array));