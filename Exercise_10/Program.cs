// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число и мы покажем его среднюю цифру");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Число не трехзначное");
    return;
}
int secondDigit = number % 100;
Console.WriteLine("Принимаем число: " + number);
int result = secondDigit / 10;
Console.WriteLine("Вторая цифра числа: " + result);

