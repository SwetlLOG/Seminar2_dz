// : Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
//3, 5 -> 243 (3⁵)   2, 4 -> 16

using System;

class Program
{
  public static int Main()
  {
    //число A
    Console.Write("Введите число A   : ");
    int number = int.Parse(Console.ReadLine());
    //число B
    Console.Write("Введите число B : ");
    int Namber = int.Parse(Console.ReadLine());
   
    int resalt = 1;
    for (int i = 0; i <Namber; i++)
    {
      resalt *= number;
    }
    Console.WriteLine("{2} ( {0} ^ {1})", number, Namber, resalt);
    Console.ReadKey();
    return 0;
  }
}