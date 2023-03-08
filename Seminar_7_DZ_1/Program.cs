// Задайте двумерный массив размером m×n, заполненный случайными
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9



  //Заполнение матрицы
 // FillMatrix ( matrix, minValue, maxValue);

    double[,] matrix = new double[3, 4];
    

    Random r = new Random();

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 4; j++)
      {
        matrix[i, j] = Math.Round(r.Next(-100, 100) * 0.1, 1);
       
        Console.Write("{0}  ", matrix[i, j]);
      }
      Console.Write("\t   ");
      Console.WriteLine();
    }

    Console.ReadLine();
 