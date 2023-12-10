// Задача 3:
//   Задайте произвольный массив. 
//   Выведете его элементы, начиная с конца, используя рекурсию.

void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.Write("] => ");
}

void(int[] array, int index)
{
  if (index < 0)
  {
    return;
  }

  Console.Write(array[index]);
  if (index > 0)
  {
    Console.Write(" ");
  }

  PrintArrayReverse(array, index - 1);
}

int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArray(array);
PrintArrayReverse(array, array.Length - 1);