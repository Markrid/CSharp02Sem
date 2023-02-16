// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Уважаемый пользователь, введите трёхзначное число: ");
int value = Convert.ToInt32(Console.ReadLine());
int secondNum = 0;
if (value >= 100 && value <= 999 || value >= -999 && value <= -100)
{
    secondNum = value / 10 % 10;
    Console.WriteLine("Вторая цифра числа " + value + " равна: " + Math.Abs(secondNum));
}
else
{
    Console.Write("Уважаемый пользователь вы ввели некорректное число. Попробуйте еще раз");
}