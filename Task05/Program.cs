﻿Console.WriteLine("Введите натурально число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number ;
while (count<=number)
{
  Console.Write($"{count}");
  count++;  
}
