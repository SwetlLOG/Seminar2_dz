// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11 82 -> 10  9012 -> 12




class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число число   ");
        var number = Convert.ToInt32(Console.ReadLine());
        var sum = 0;
        while(number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine(sum);
    }
}

 
    
    
    
   







