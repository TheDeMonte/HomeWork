// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a = -9 b = -3 -> max = -3

int a = -3; // Специально изменил условие задачи, чтобы не всегда только "b" было максимальным
int b = -9;
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
