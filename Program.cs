Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
int rez = 1;
int power(int a, int b)
{
    //int rez = 1;
    for (int k = 1; k <= b; k = k + 1)
    {
        rez = rez * a;
    }
    return rez;
}
power(a, b);
Console.WriteLine("Результат: " + rez);