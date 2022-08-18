Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int count = value * (-1);
while (count <= value)
{
    Console.Write($"{count} "+"");
    count ++;
}