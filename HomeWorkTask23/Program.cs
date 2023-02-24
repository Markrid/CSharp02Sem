// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Добро пожаловать! Программа принимает чило N и выдаёт кубы все чисел от 1 до N!");
Console.Write("Ввидет число N: ");
int number = Convert.ToInt32(Console.ReadLine())!;
int[] array = new int[number];
int i = 0;
while (i < number)
{
    array[i] = Convert.ToInt32(Math.Pow(i + 1, 3));
    i++;
}
Console.Write($"Вы ввели {number}, все кубы от 1 до {number}: ");

i = 0;
while (i < number)
{
    Console.Write(array[i] + " ");
    i++;
}
