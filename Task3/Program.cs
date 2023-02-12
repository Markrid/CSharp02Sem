// Программа, которая на входе принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    N = N * (-1);
}
int negativeN = N * (-1);
while (negativeN <= N)
{
    Console.Write(negativeN + " ");
    negativeN += 1;
}