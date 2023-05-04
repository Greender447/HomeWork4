// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number % 10;
int number2 = number / 100;
int number3 = (number / 10);
int number4 = number3 % 10;
int sum = number1 + number2 + number4;
Console.WriteLine(sum);

