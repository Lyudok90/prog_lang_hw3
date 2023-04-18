/*Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом*/


Console.WriteLine("Enter a five-digit number: ");
int number = int.Parse(Console.ReadLine());
int temp = number;
int pol = 0;

if(number > 9999 && number < 100000)
{
    while(temp!=0)
        {
            pol = pol*10 + temp%10;
            temp /= 10;
        }
    if(number == pol)
    Console.WriteLine("Your number is polindrom ");
    else
    Console.WriteLine("Your number is not polindrom");
} 

else
Console.WriteLine("Enter a five-digit number: ");
