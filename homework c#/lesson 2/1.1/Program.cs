Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());
while (a > 999) 
a=a/10;
if (a > 99 && a > 10)
    Console.WriteLine($"вторая цифра {a % 100 / 10}");
else if (a>9 && a<100)
    Console.WriteLine($"вторая цифра {a % 10}");
    else
    Console.WriteLine("второй цифры нет");



