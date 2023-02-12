// Программа, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Clear();
Console.Write("Введите первое число: ");
int FirstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondValue = Convert.ToInt32(Console.ReadLine());

if (SecondValue * SecondValue == FirstValue)
{
    Console.Write("Число " + FirstValue + " является квадратом от " + SecondValue);
}
else
{
    Console.Write("Число " + FirstValue + " не является квадратом от " + SecondValue);
}