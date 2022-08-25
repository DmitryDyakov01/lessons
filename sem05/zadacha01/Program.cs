int[] numbers = new int[7];
void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}
void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityEven(int[] array)
{
    int evenNumbers = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] % 2 == 0)
    {
      evenNumbers++;
    }
    }
  return evenNumbers;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int evenNumbers = QuantityEven(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {evenNumbers}");
