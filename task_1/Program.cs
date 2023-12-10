// Задача 1:
//  Задайте значения M и N. 
//  Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M = {m}; N = {n} -> \"{PrintNumbers(m, n)}\"");

string PrintNumbers(int start, int end)
{
  if (start > end)
  {
    return "";
  }
  else
  {
    return start + (start < end ? ", " + PrintNumbers(start + 1, end) : "");
  }
}
