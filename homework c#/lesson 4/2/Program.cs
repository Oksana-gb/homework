// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine());

int Count(int numA)
{
    int sum = 0;
    while (numA > 0)
    {
        numA /= 10;
        sum++;
    }
    return sum;
}
Console.WriteLine(Count(num));