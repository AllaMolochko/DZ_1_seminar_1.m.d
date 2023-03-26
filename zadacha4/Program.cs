// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

 Console.Write("Введите число: ");
 int n = int.Parse(Console.ReadLine());
        
int i % 2 == 0; 

 if (n > 1) 
{
    while(i <= n)
    {
      Console.Write(i + " ");
      i = i + 2;
    }
}
