/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number <= 0 || number >= 8)
{
    Console.WriteLine("Читай внимательнее, человек! Такого дня недели не существует!");
    return; 
}
if (number == 1)
    Console.WriteLine("Понедельник "); // можно сократить убрав перечисление дней недели
if (number == 2)
    Console.WriteLine("Вторник ");
if (number == 3)
    Console.WriteLine("Среда ");
if (number == 4)
    Console.WriteLine("Четверг ");
if (number == 5)
    Console.WriteLine("Пятница ");
if (number == 6)
    Console.WriteLine("Суббота ");
if (number == 7)
    Console.WriteLine("Воскресенье ");
if (number <= 5)
  Console.WriteLine("Рабочий день");
if (number >= 6)
    Console.WriteLine("Выходной день");
