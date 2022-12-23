// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int rec(int m, int n)
{
    if (n < 0 && m < 0 || n < m)
        return 0;
         return rec(m, n-1) + n;
}
Console.Clear();
Console.WriteLine("Введите начальное натуральное число m: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное натуральное число n: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(a, b));
