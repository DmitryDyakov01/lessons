Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число с: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;

Console.WriteLine(max);