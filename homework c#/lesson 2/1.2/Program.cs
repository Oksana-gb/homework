// Console.WriteLine("введите число");
// int a = int.Parse(Console.ReadLine());
// if (a>99) 
// Console.WriteLine($"тертья цифра {a%10}");
// else if (a<100)
// Console.WriteLine("третьей цифры нет");



// Console.WriteLine("введите число");
// char[] a = Console.ReadLine().ToCharArray();
// if (a.Length > 2)
// Console.WriteLine(a[2]);
// else
// Console.WriteLine("третьей цифры нет");

Console.WriteLine("Введитеь число");
int num = int.Parse(Console.ReadLine());
int firstNum, secondNum;
if (num < 100 & num > -100) {Console.WriteLine("третьего числа нет");}
else
{
int divider = 1000000000;
while (true){
firstNum = num / divider;
if (firstNum != 0) {break;}
divider = divider / 10;
}
secondNum = (num - firstNum * divider) / (divider/10);
Console.WriteLine((num - firstNum * divider - secondNum * (divider / 10)) / (divider / 100));
}