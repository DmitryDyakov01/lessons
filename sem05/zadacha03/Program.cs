double[] Numbers = new double[7];
  for (int i = 0; i < Numbers.Length; i++ )
  {
    Numbers[i] = new Random().Next(1, 6);
    Console.Write(Numbers[i] + " ");
  }

double maxNumber = Numbers[0];
double minNumber = Numbers[0];

  for (int i = 1; i < Numbers.Length; i++)
  {
    if (maxNumber < Numbers[i])
    {
      maxNumber = Numbers[i];
    }
        if (minNumber > Numbers[i])
    {
      minNumber = Numbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nРазница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
