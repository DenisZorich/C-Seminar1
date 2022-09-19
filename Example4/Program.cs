// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int GetNumber()   // создали функцию
{
    Console.WriteLine("Введите число");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}
int numberA = GetNumber();
if (numberA % 7 == 0 && numberA % 23 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно!");
}
