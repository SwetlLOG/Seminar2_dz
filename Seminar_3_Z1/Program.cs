// Написать программу, которая принимает на вход пятизначное число и проверяет, является ли оно
// палидромом 14212 - нет, 12821 - да, 23432 - да

//Console.WriteLine (" Введите пятизначное число   ");

//int main = Convert.ToInt32(Console.ReadLine());


//int[] arr_main;
//Метод создания массива
//int[] CreateArr 

int[] arr = { 2, 3, 4, 3, 2 };



void PrintArray(int[] array)
{
  int count = array.Length;

  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }


}

int index = arr.Length;
for (int i = 0; i < index / 2; i++)

{
  if (arr[i] != arr[index - i - 1])
  {
    Console.WriteLine(" No ");
  }
  if (arr[i] == arr[index - i - 1])
  {
    Console.WriteLine(" Yes ");
  }

}

PrintArray(arr);
