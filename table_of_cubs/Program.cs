﻿/*Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

for(int i = 1; i <= number; i++){
    int cube = i*i*i;
    Console.WriteLine($"Cube of {i} is {cube} ");
}
