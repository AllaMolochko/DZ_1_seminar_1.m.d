// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
double a = 4; 
double.TryParse(Console.ReadLine(), out a);

if (a%2 ==0)

{
  Console.WriteLine("число чётное");
}

else
 
{
  Console.WriteLine("число нечётное");
}
