// Задача # 2
// Программа, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.
Console.Clear();
Console.Write("Уважаемый пользователь, представьтесь!");
string username = Console.ReadLine();
if (username.ToLower() == "михаил")
{
    Console.WriteLine("Здравствуйте, Михаил! Большое спасибо за семинар, всё очень понятно и доступно объясняете");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
Console.Write("Пожалуйста введите первое число для сравнения: ");
int FirstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите второе число для сравнения: ");
int SecondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Идёт обработка запроса...");
Console.WriteLine("Спасибо за ожидание!");
if (FirstNum == SecondNum)
{
    Console.WriteLine(username + ", вы ввели равные числа, пожалуйста повторите попытку");
}
else
{
    if (FirstNum < SecondNum)
    {
        Console.WriteLine(username + ", введённое вами второе число " + "(" + SecondNum + ")" + " больше первого " + "(" + FirstNum + ")");
    }
    else
    {
        Console.WriteLine(username + ", введённое вами первое число " + "(" + FirstNum + ")" + " больше второго " + "(" + SecondNum + ")");

    }
}