// Задача # 3
// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Уверен, что есть другой, более правильны и простой вариант, но пока меня хватило только на это.
Console.Clear();
Console.Write("Пожалуйста введите первое число для сравнения: ");
int FirstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите второе число для сравнения: ");
int SecondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите третье число для сравнения: ");
int ThirdNum = Convert.ToInt32(Console.ReadLine());
int max = FirstNum;
if (max > SecondNum)
{
    if (max > ThirdNum)
    {
        Console.WriteLine("Максимальным из введённых вами чисел является: " + max);
    }
    else
    {
        Console.WriteLine("Максимальным из введённых вами чисел является: " + ThirdNum);
    }
}
else
{
    max = SecondNum;
    if (max > ThirdNum)
    {
        Console.WriteLine("Максимальным из введённых вами чисел является: " + max);
    }
    else
    {
        Console.WriteLine("Максимальным из введённых вами чисел является: " + ThirdNum);
    }
}