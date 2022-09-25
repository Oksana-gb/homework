// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string PrintNumbers(int start, int end)
{
if (start == end) return start.ToString();
return (start + " " + PrintNumbers(start + 1, end));
}

Console.Write(PrintNumbers(4,8));