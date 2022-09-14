int a = 5;
int b = 7;
int max = a;
int min = b;

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
