// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6


int number = new Random().Next(-100000, 100000);
Console.WriteLine($"Получено число {number}");
if (number < 0)
    number = (number < 0 ? -number : number);
if (number < 100)
    Console.WriteLine($"У числа {number} нет третьей цифры.");
else
{
    int FindDigit(int arg)
    {
        int result = 0;
        while (arg > 999)
            arg = arg / 10;
        result = arg % 10;
        return result;
    }
    Console.Write("третья цифра полученного числа -> ");
    Console.WriteLine(FindDigit(number));
}

