// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



int N = InputInt("Введите положительное число");
int I = 1;

Console.WriteLine(Number(N, I));

int Number(int N, int I)

{
    if (N == I)
        return N;
    else
        Console.Write($"{Number(N, I + 1)}, ");
    return I;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

