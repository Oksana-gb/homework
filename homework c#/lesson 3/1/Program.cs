Console.WriteLine("введите число");
char[] a = Console.ReadLine().ToCharArray();
int array = a.Length;
int i = 0;
int count = 1;
int sum = 0;
while (count < array / 2 + 1)
{
    if (a[a.Length - count] == a[i])
        sum++;
    i++;
    count++;
}
if (sum == array / 2)
{
    Console.WriteLine("данное число является палиндромом");
}
else
{
    Console.WriteLine("данное число НЕ является палиндромом");
}