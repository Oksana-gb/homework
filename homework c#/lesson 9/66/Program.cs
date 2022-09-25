// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int PrintNumbers(int start, int end)
{
    if (start == end ) return start;
    return (start+PrintNumbers(start+1, end));
}

Console.Write(PrintNumbers(4,8));
