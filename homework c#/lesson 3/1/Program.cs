// Console.WriteLine("введите число");
// char[] a = Console.ReadLine().ToCharArray();
// int i = 0;
// int sum = 0;
// for (int c = 1; c < a.Length / 2 + 1; c++)
// {
//     if (a[a.Length - c] == a[i])
//         sum++;
//     i++;
// }
// if (sum == a.Length / 2)
// {
//     Console.WriteLine("данное число является палиндромом");
// }
// else
// {
//     Console.WriteLine("данное число НЕ является палиндромом");
// }

Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine());
int result = 0;
for (int temp = num; temp > 0; temp /= 10)
{
    result = result * 10 + temp % 10;
Console.WriteLine(result);
}
if (num == result)
{
    Console.WriteLine("данное число является палиндромом");
}
else
{
    Console.WriteLine("данное число НЕ является палиндромом");
}