Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());
if (a>99) 
Console.WriteLine($"тертья цифра {a%10}");
else if (a<100)
Console.WriteLine("третьей цифры нет");



// Console.WriteLine("введите число");
// char[] a = Console.ReadLine().ToCharArray();
// Console.WriteLine(a[2]);