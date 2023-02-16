// Напишите программу, которая выводит третью цифру заданного числа или
//сообщает, что третьей цифры нет 645-.5, 78->третьей цифры нет, 32679->6

//Console.Write("Введите заданное число ");
//String value = Console.ReadLine();
//int resalt = Convert.ToInt32 (value);

int value = 65894;



if (  value >=100 && value <= 999)

{
  int resalt = value % 10;
  Console.WriteLine(resalt);
}

if (value >= 999 )

{
  int resalt = value/100 % 10;
  Console.WriteLine(resalt);
}

if (value < 100)

{
  Console.WriteLine("Третьей цифры нет");
}