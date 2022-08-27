Console.WriteLine("введите число трехзначное число");
int a = int.Parse(Console.ReadLine());
if (a<1000 & a>99) 
Console.WriteLine($"вторая цифра {a%100/10}");
else 
Console.WriteLine("оно не трехзначное, введи число заново");