// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число и мы покажем его третью цифру или сообщим, что ее нет");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
int thirdDigit = number % 10;

if(number > 9999)
{
    Console.WriteLine((number / 100) % 10);
}
else
Console.WriteLine(thirdDigit);