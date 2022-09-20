// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());  // 5
number = Math.Abs(number);  // для возможности вводить отрицательное число
int number2 = number * -1;  // -5
while (number2 <= number)   // -5<5 да
{
    Console.Write(number2 + ", ");
    number2 = number2 + 1;
}
//Console.Write("\b\b"); имитируется нажатие backspace, удаляется запятая на конце
Console.WriteLine();