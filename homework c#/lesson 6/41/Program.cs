// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] newArray = array.Select(ch => int.Parse(ch.ToString())).ToArray();
Console.WriteLine(Count(newArray));

int Count(int[] arr)
{
    int sum = 0;
    foreach (int value in arr)
    {
        sum += value > 0 ? 1 : 0;
    }
    return sum;
}