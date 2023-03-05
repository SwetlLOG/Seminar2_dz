// Пользователь вводит с клавиатуры N чисел. Сколько чисел больше 0 ввел пользователь

int Number(string text)
{
  System.Console.Write(text);
  string value = Console.ReadLine();
  int resalt = Convert.ToInt32(value);

  return resalt;
}
int[] InPutArray(int length)
{
  int[] array = new int[length];

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Number($"Введите N{i}:  ");
  }
  return array;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}{"\t"}");


  }
  Console.WriteLine();
}

int CountPositiveNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0 )
    {
      count++;
    }
  }
  return count;
}


int length = Number("Введите N: ");
int [] array;
array = InPutArray(length);
PrintArray(array);
Console.WriteLine($"Больше 0:   {CountPositiveNumbers(array)}");