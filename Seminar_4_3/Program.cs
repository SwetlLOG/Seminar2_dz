//  Напишите метод, который задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]      6, 1, 33 -> [6, 1, 33]

//using System;


//class Program
//{
//static void Main(string[] args)



int[] number = { 1, 2, 5, 7, 19 };
Console.Write("[");
for (int i = 0; i < number.Length; i++)

{
  Console.Write($"{ number[i]}");
}

Console.Write("]");


//}