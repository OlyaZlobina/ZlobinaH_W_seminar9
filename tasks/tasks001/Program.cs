// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Clear();
Console.Write("Введите первое число: ");               
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummOfNums(M, N));

int SummOfNums(int m, int n)
{    
    if(m == n) return m;
    else return  m + SummOfNums(m + 1, n);
}



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FAkkerman(int M, int N)
{
    if ( M == 0) return N + 1;
    else if (M > 0 && N == 0) return FAkkerman(M - 1, 1);
    else 
    return FAkkerman(M - 1, FAkkerman(M, N - 1));
    
}
Console.Clear();
Console.Write("Введите первое число: ");               
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FAkkerman(m, n));
