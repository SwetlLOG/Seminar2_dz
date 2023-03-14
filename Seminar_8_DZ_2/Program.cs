// Задайте прямоугольный двумерный массив. Напишите программу, которая 
//будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт 
//номер строки с наименьшей суммой элементов: 1 строка

int n = Numbers("Введите n: ");
int m = Numbers("Введите m: ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSum = 0;
int sum = SumNumbers(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumNumbers(array, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - строка с наименьшей суммой  =  {sum}  ");


int SumNumbers(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

int Numbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}