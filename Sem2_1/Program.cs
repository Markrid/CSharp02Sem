// Работаем с МАТЕМАТИКОЙ

// Программа которая выводит случайоное число из отрезка то 10 до 99 и показывает наибольшую цифру в двузначном числе

// int number = new Random().Next(10,100);
// Console.WriteLine("Сгенерированное число: " + number);
// int firstNum = number/10;
// Console.WriteLine("Первая цифра в числе: " + firstNum);
// int secondNum = number%10;
// Console.WriteLine("Вторая цифра в числе: " + secondNum);
// int max = Math.Max(firstNum, secondNum);
// Console.WriteLine(max + " - бОльшая из цифр в числе");


// Программа, которая выводит случайоное трёхзначное число и показывает только первую и третью цифры

// int number = new Random().Next(100, 1000);
// int result = number / 100 * 10 + number % 10;
// Console.WriteLine("Случайное число: " + number);
// Console.WriteLine("Первая и последняя цифра: " + result);


// // Программа, которая будет принимать два числа и выводить, является ли второе число кратным первому. Если число 2 кратно числу 1, то программа выводит остаток от деления.

// Console.Write("Введите первое число: ");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2=Convert.ToInt32(Console.ReadLine());

// if (num1%num2==0)
// {
//      Console.Write("Делиться без остатка!");
// }
// else
// {
//     // Используем интерполяци для склеивания строк текста.
//     Console.Write($"Не кратно, остаток равен: {num1%num2}");
// }


// Программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&": Shift + 7 на англ. раскладке - "И": апельсины и яблоки (берется и апельсины, и яблоки ОДНОВРЕМЕННО)
// "||": Shift + | (на англ.): "ИЛИ": апельсины ИЛИ яблоки (или апельсины, или яблоки, или все вместе)

if (number % 7 == 0 && number % 23 == 0)
{
Console.WriteLine("Число кратно одновременно 7 и 23");
}
else
{
Console.WriteLine("Число НЕ кратно одновременно 7 и 23");
Console.WriteLine($"Остаток от деления на 7 равен: {number % 7}");
Console.WriteLine($"Остаток от деления на 23 равен: {number % 23}");
}