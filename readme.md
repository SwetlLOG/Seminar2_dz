# Задачи

 ### Задача 1
  В двумерном массиве показать позиции числа, заданного пользователем, или
показать, что такого числа нет [KOД](DZ Seminar/Seminar5_0_1)

На самом деле числа вещественные, просто их надо отформатировать, типа "{0,6:F2}", тогда вы увидите нули после запятой. Если вам нужны не нули, то это надо либо генерить целые до 10000, преобразовать в double и делить на 100, либо использовать NextDouble().


Вещественные рандомные двумерный массив
double[,] a = new double[5, 10];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}  
 // Метод заполнения массива случайными вещественными числами от -10 до 10
double[,] FillMatrix(int rows, int cols)
{
    double [,] array = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = Math.Round(rand.Next(-100, 101)*0.1, 1);
        }
    }
    return array;
}

Среднее арифметическое
            int[,] a = new int[n, n];
            Random rn = new Random();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = rn.Next(-100, 101);
                    Console.Write("{0, 4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nНовый вид массива:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if ((a[i, j] < 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        g = (i + j) / a[i, j];
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0, 4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nСреднее арифметическое отрицательных элементов матрицы = {0}", g);
            Console.ReadKey();

    
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
41
42
43
44
45
46
47
48
49
50
51
52
53
54
55
56
57
58
59
60
61
62
63
64
65
                int[,] Matrix = new int[7, 7];
 
                Random gen = new Random();
                string resultat="";
                int  count=0;
                double sum = 0;
 
 
            
 
                for (int i = 0; i < Matrix.GetLength(0); i++)
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                        Matrix[i, j] = gen.Next(-30,30);
 
            
 
 Писк суммы элементов в столбце
          //  Matrix=new int[7,7]{{-1,1,1,1,1,1,1},{-40,1,1,1,1,1,1},{1,1,1,1,1,1,1},{1,1,1,1,1,1,1},{1,1,1,1,1,1,1},{1,1,1,1,1,1,1},{1,1,1,1,1,1,1}};
 
 
 
               for (int i = 0; i < Matrix.GetLength(0); i++)
               {
                   resultat += "\n";
                   sum=0;
                   count=0;
 
                   for (int j = 0; j < Matrix.GetLength(1); j++)
                   {
                       resultat += Matrix[i, j] + "\t";
 
                   }
               }
 
 
               Console.WriteLine(resultat);
               resultat="";
               bool first = true;
 
               for (int i = 0; i < Matrix.GetLength(1); i++)
               {
                   if (!first)
                   resultat += "\t";
                   sum=0;
                   count=0;
                   first = false;
                   for (int j = 0; j < Matrix.GetLength(0); j++)
                       if (Matrix[j, i] < 0)
                       {
 
                           sum += Matrix[j, i];
                           count++;
                       }
 
                   if (count != 0)
                       resultat += Math.Round((sum / count),2);
                   if (count == 0)
                       resultat += "-"