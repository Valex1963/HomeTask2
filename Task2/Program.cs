﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int A =int.Parse(Console.ReadLine());
int b = 0;

if (A >= 100)  
 {
    while (A > 999)
    {
        A = A / 10;
    }
    
    Console.WriteLine($"Третья цифра введенного числа: {b = A % 10}");     

 }   
        
else

  Console.WriteLine("Третьей цифры нет.");
