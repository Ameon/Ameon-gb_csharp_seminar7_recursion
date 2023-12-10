// Задача 2:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int originalM = m;
int originalN = n;

// Меняем значения местами
(m, n) = Swap(m, n, true);

int result = Akkerman(m, n);

Console.WriteLine($"m = {originalM}, n = {originalN} -> A(m, n) = {result}");

int Akkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (m > 0 && n == 0)
  {
    return Akkerman(m - 1, 1);
  }
  else
  {
    return Akkerman(m - 1, Akkerman(m, n - 1));
  }
}

(int, int) Swap(int m, int n, bool isFirstCall)
{
  if (isFirstCall)
  {
    return Swap(n, m, false);
  }
  else
  {
    return (m, n);
  }
}
