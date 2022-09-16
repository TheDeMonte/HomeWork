//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a = 2 b = 10

int a = 2;
int b = 10;
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
