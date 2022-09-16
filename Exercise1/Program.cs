// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a = 5; b = 7
int a = 5;
int b = 7;
int max = a;
int min = a;

if (b > max)
{
    max = b; min = a;
    Console.Write ("Максимальное число: ");
    Console.WriteLine (max);
    Console.Write ("Минимальное число: ");
    Console.Write (min);
}
else 
{
    max = a; min = b;
    Console.Write ("Максимальное число: ");
    Console.WriteLine (max);
    Console.Write ("Минимальное число: ");
    Console.Write (min);
}
