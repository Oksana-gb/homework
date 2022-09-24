// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = new int[3, 3, 3];

Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine(i+1 + " слой");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = rand.Next(10, 100);
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}