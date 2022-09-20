// Программа, которая на вход принимает число и выдает его квадрат

// int a = 5;
// // int b;
// // b = a * a;
// int b = a *a;
// Console.WriteLine (b);

// Программа, чтобы вводить числа уже в запущенной программе

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = a *a;
// //Console.WriteLine (b);
// //Console.WriteLine ("Результат: " + b);
// //Console.WriteLine ($"Результат: {b}");
// Console.WriteLine ($"{a} * {a} = {b}");


// Базовые конструкции. Ветвление

int rain = 1;        //0 - не идет дождь, 1 - есть дождь
if (rain == 1)
{
    Console.WriteLine ("Возьми зонт");
}
else
{
    Console.WriteLine ("Можешь идти в сандалях");
}

// Базовые конструкции. Цикл

int time = 11;
while (time < 22)
{
    time++;
    Console.WriteLine("Еще можно смотреть мультики. Время:" + time);
}
Console.WriteLine("Пора спать");
Console.WriteLine(time);