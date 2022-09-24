// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


bool inArray(int[,,] arr, int value)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == value) return true;
            }
        }
    }
    return false;
}

int[,,] array = new int[3, 3, 3];

Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine(i + 1 + " слой");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int value = rand.Next(10, 100);
            if (inArray(array, value) == false)
            {
                array[i, j, k] = value;
            }
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
