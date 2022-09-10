// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine());

int Count(int numA)
{
    int sum = 0;
    while (numA > 0)
    {
        sum += numA % 10;
        numA /= 10;
    }
    return sum;
}
Console.WriteLine(Count(num));