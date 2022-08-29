int[] array = new int[8];
Random RandomNumber = new Random();
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
array[i] = RandomNumber.Next(1, 100);
Console.Write("{0} ", array[i]);
}