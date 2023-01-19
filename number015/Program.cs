//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 | number < 1)
    Console.WriteLine("Введите корректное значение дня недели, от 1 до 8");
else
{
Console.Write($"День недели {number},  ");
bool Day(int arg)
{
    bool result = false;
    if (arg == 6 | arg == 7)
        result = true;
    else
        result = false;
        return result;
}
Console.WriteLine($"выходной? -> {Day(number)}");
}


