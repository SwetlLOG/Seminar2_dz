//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве не




internal class Program

{
  static void Main(string[] args)
  {
    int[,] myArray = new int[3, 4]
  {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
  };

    int rows = 2; int columns = 1; int position = myArray[rows, columns];
    {
      for (int i = 0; i < myArray.GetLength(0); i++)
      {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
          if (position == myArray[rows, columns])
          {
            Console.WriteLine($"Значение элемента:{position}");
          }

         if (position != myArray[rows, columns] )
          {
            Console.Write($"Значения нет  ");
          }
       break;
        }
      }
    }
  }
}
