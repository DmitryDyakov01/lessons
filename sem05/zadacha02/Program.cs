Console.Write($"Введи количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int number, int min, int max)
  {
  int[] randomNumbers = new int[number];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 0)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(number, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");

