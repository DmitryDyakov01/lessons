
Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (count == 1)
{
    count +=1;
}


while (count <= value)
{
    Console.Write($"{count} "+"");
    count+=2;
}
