// Программа, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

Console.Write("Уважаемый пользователь, введите семизначное число: ");
int value = Convert.ToInt32(Console.ReadLine());
int thirdNumL = 0;
int thirdNumR = 0;
string text = Convert.ToString(value);
if (value <= 9999999 && value >= 1000000 || value >= -9999999 && value <= -1000000)
{
    thirdNumL = value / 10000 % 10;
    thirdNumR = value / 100 % 10;
    Console.WriteLine("Третья цифра числа " + value + " слева равна: " + Math.Abs(thirdNumL) + "," + " а справа равна: " + Math.Abs(thirdNumR));
}
else
{
    if (value >= -99 && value <= 99)
    {
        Console.WriteLine("Указанное вами чило не содержит третьей цифры");
    }
    else
    {
        if (value >= 100 && value <= 999999)
        {
            Console.WriteLine("Вы не соблюдаете первоначальное условие, но я всё равно постараюсь определить третью цифру...");
            Console.WriteLine("Скорее всего, третья цифра вашего числа равна: " + text[2]);
        }
        else if (value >= -999999 && value <= -100)
        {
            Console.WriteLine("Вы не соблюдаете первоначальное условие, но я всё равно постараюсь определить третью цифру...");
            Console.WriteLine("Скорее всего, третья цифра вашего числа равна: " + text[3]);

        }
    }

}