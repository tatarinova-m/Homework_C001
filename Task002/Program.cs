//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите три числа: ");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int count = 0;

while (count < 4)
{
    if (number1 > number2)
    {
        max = number1;
    }

    else
    {
        max = number2;
    }


    if (max > number3)
    {
        max = max;
    }

    else
    {
        max = number3;
    }

    count++;
}

Console.WriteLine($"Максимальное значение = {max}");

