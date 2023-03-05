// Задача 
using static Ex002;

// Run();

void foo()
{
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 3; j++)
    {
      System.Console.Write($"{i}{j} ");
      if (j == 1 && i == 1)
      {
        return;
      }
    }
    System.Console.WriteLine();
  }
}


foo();
System.Console.WriteLine();