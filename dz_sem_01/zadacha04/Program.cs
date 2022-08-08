
Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int count = 2;


while (count <= value)
{
    Console.Write($"{count} "+"");
    count+=2;
}
