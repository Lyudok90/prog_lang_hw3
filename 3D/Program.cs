/*Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.*/

Console.WriteLine("Enter x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z2: ");
int z2 = int.Parse(Console.ReadLine());


int X = x2 - x1;
int Y = y2 - y1;
int Z = z2 - z1;

double length = X * X + Y * Y + Z * Z;
Console.WriteLine("Length is " + length);
