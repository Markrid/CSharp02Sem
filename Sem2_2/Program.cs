

// var stringNumber = "1234Привет";
// int number; // Если строчка состоит из чисел, то сюда попадает наше число
// bool isNumber = int.TryParse(stringNumber, out number); // True - cтрочка состоит из чисел, False - пр-т буквы, спецсимволы
// Console.WriteLine(isNumber);
// Console.WriteLine(number);


// Про координаты: 

Console.Write("Введите координату по оси Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());
// A(x; y)
if (x > 0 && y > 0)
{
Console.WriteLine("Четверть: I");
}
else if (x < 0 && y > 0)
{
Console.WriteLine("Четверть: II");
}

else if (x < 0 && y < 0)
{
Console.WriteLine("Четверть: III");
}
else if (x > 0 && y < 0)
{
Console.WriteLine("Четверть: IV");
}
else
{
Console.WriteLine("Попаданиние на ось");
}


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// A(x1; y1)
Console.Write("Введите координату точки A по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
// B(x2; y2)
Console.Write("Введите координату точки B по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
// AB = √(x2 - x1)^2 + (y2 - y1)^2
// Math.Sqrt(25) => 5
// Math.Pow(число, степень) => Math.Pow(4, 2) => 4 возводите во 2 степень = 16
var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2));
Console.WriteLine(Math.Round(result,3)); // До целого числа

// double test = 1.234;
// // Math.Round(число, количество знаков после запятой) => 1.23
// Console.WriteLine(Math.Round(test, 2)); // => 1.23
// A(x1; y1); B(x2; y2)
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// for(начало; условие; увеличение переменной - счетчика)
for(int i = 1; i <= N; i++)
{
Console.Write(Math.Pow(i, 2) + "\t");
}