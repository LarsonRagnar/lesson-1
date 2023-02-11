// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("1" + "1") строчка
//Console.WriteLine(1 + 1) число
//Поэтому мы конвертируем строчку в число int secondValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue == Math.Pow(secondValue, 2)) //Math.Pow(secondValue, 2)) = secondValue * secondValue
{
    Console.WriteLine("Число " + " является квадратом от " + secondValue);
}
else
{
    Console.WriteLine("Число " + " НЕ является  квадратом от " + secondValue);
}
