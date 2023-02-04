//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x =1;
if (n > 0) 
{
    while (x < n+1)
    { 
       if (x%2 == 0)
       {
        Console.Write($" {x}");
       }
        x++;
    }
}

else
{
    Console.Write("Введите число больше 0");
}
