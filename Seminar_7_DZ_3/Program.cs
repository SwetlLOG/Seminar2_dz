// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] matrix = new int[3, 4];
{

  Random r = new Random();

  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      matrix[i, j] = r.Next(1, 10);        //  (r.Next(-100, 100) * 0.1, 1);,

      Console.Write("{0}  ", matrix[i, j]);
    }
    Console.Write("\t   ");
    Console.WriteLine();
  }

  Console.ReadLine();

  int[,] Matrix = (matrix); int c1 = 0; int c2 = 0; ct3 = 0; int c42 = 0; 
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      if   = i;
      {

      }
      }

  }