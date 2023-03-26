// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = 5; 
int b = 7;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);
if (a>b)
{
  System.Console.WriteLine(a);
} 
else
 
{
    System.Console.WriteLine(b);
}
