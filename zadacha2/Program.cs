// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a=2;
int b=3;
int c=7;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);
int.TryParse(Console.ReadLine(), out c);
if (a>b)
{
  System.Console.WriteLine(a);
}
if (c>a)
{
  System.Console.WriteLine(c);
}

