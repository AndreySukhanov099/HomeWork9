/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите число от которого нужно найти сумму");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число до которого нужно найти сумму");
int N = Convert.ToInt32(Console.ReadLine());

SumMN(M,N);
int Sum(int M, int N)
{
    int res = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        res = M + Sum(M, N);
        return res;
    }
}
void SumMN(int M, int N)
{
    Console.Write(Sum(M - 1, N));
}