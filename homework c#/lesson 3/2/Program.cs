Console.WriteLine("введите цифру");
double xa = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру");
double ya = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру");
double za = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру");
double xb = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру");
double yb = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру");
double zb = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.WriteLine(Math.Round(d, 2));



