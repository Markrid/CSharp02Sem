// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string value = Console.ReadLine();
if (value[0] == value[4] && value[1] == value[3])
{
    Console.Write($"Вы ввели {value} - это полиндром!");
}
else
{
    Console.Write($"Вы ввели {value} - это НЕ полиндром!");
}