Console.WriteLine("Введите число которое нужно возвести в степень");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите исло в степень которого нужно возвести");
int a = Convert.ToInt32(Console.ReadLine());
double d = Math.Pow(m, a);
Console.WriteLine(d);