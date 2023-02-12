// Программа, которая принимает одно число и выдаёт его квадрат.

Console.Clear();
Console.Write("Добро пожаловать! Введите число, для которого мы ищем квадрат: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine("Квадрат введённого числа = " + result);
Console.WriteLine("Спасибо за использование приложения!");