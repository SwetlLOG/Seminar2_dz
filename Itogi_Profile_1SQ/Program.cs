

string[] Arr1 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] Arr2 = new string[Arr1.Length];

void ConditionCheck(string[] Arr1, string[] Arr2)
{
  int count = 0;
  for (int i = 0; i < Arr1.Length; i++)
  {
    if(Arr1[i].Length <= 3)
    { 
      Arr2[count] = Arr1[i];
      count++;
    }
  }
}

void PrintArray(string[] Array)
{
  for (int i = 0; i < Array.Length; i++)
  {
    Console.Write($"{Array[i]}");
  }
  Console.WriteLine();
}

ConditionCheck(Arr1, Arr2);
PrintArray(Arr2);