// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число: "); // Вывод чисел на новую строку
string number = Console.ReadLine();
int Length = number.Length; 

if (Length == 5) //обохначаем длину не более
{
    if (number[0] == number[4] && number[1] == number[3]) //замена индексов
    {
        Console.WriteLine($"{number} - Палиндром"); //вывод еси бъет
    }
    else //если
    {
        Console.WriteLine($"{number} - НЕ палиндром"); //вывод если не бъет
    }
}
else //если
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным"); //ваывод не бъют пред числа
}
