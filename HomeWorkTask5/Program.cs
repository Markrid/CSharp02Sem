// Задача # 5
// Программа, которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N
Console.Clear();
Console.Write("Пожалуйста введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 2;
while (temp <= N)
{
    Console.Write(temp + " ");
    temp += 2;
}