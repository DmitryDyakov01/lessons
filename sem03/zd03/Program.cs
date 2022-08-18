Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int count = 0;
  int length = cube.Length;
  while (count <  length)
  {
    cube[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}

void PrintArry(int[] coll)
{
  int num = coll.Length;
  int index = 0;
  while(index < num){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);