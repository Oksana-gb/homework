Console.WriteLine("введите число");
char[] a = Console.ReadLine().ToCharArray();
int i = 0;
int sum = 0;
for (int c = 1; c < a.Length / 2 + 1; c++)
{
    if (a[a.Length - c] == a[i])
        sum++;
    i++;
}
if (sum == a.Length / 2)
{
    Console.WriteLine("данное число является палиндромом");
}
else
{
    Console.WriteLine("данное число НЕ является палиндромом");
}