// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (num >= 100)
{
  result = num % 10;
  System.Console.WriteLine(result);
}
else
{
  System.Console.WriteLine("третьей цифры нет");
}