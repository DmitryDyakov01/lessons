Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
string ntxt  = Convert.ToString(n);
if (ntxt.Length > 2)
{
  Console.WriteLine(ntxt[2]);
}
else
{
  Console.WriteLine(" Третьей цифры нет");
}


