// задача В двумерном массиве показать позиции числа, заданного пользователем, или
//показать, что такого числа нет

//SRP Single Respotibility Principe

void FillMatrix(int[,] matrix, int min, int max)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(min, max);
    }
  }
}

void Print(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}

string PrintGood(int[,] matrix) //Метод печати массива

{
  string resalt = String.Empty;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      resalt += $"{matrix[i, j],5} ";
    }
    resalt += "\n";
  }
  return resalt;
}

bool FindElementInMatrix(int[,] matrix, int element)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] == element)
      {
        return true;
      }
    }

  }

  return false;
}

int GetValueFromConsole(string text)
{
  int value = 0;

  bool flag = false;
  while (!flag)
  {
    Console.Wtite(text);
    int.TryParse(Console.ReadLine(), out value);
  }
  return value;

}

int[] FindPositionElementInMatrix(int[,] matrix, int element)//Возвращает х и у позиции
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] == element)
      {
        return new int[] { i, j };
      }
    }

  }
  return new int[] { -1, -1 }; //если элемент не найден возвращает -1, -1
}



int rows = GetValueFromConsole(" Введите количество строк в матрице: ");
int columns = GetValueFromConsole(" Введите количество столбцов в матрице: ");
int findItem = GetValueFromConsole(" Что ищем: ");
int matrix = new int[rows, columns];
Console.WriteLine();
FillMatrix(matrix, 0, 10);


bool check = FindElementInMatrix(matrix, findItem);

if (check)
{
  int[] pos = FindPositionElementInMatrix(matrix, findItem);
  Console.WriteLine($"row: {pos[0]} column: {pos[1]}");
}