// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string aText = Convert.ToString(a);
if (aText.Length > 2)
{
  Console.WriteLine("третья цифра " + aText[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}
