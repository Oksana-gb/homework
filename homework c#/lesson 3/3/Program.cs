Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());
for (int i =1; i < a+1; i++) 
{
double b = Math.Pow(i,3);
Console.Write($"{b}, ");
}
