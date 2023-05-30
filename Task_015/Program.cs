//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Please, enter ordinal number of the day of the week");
int day = int.Parse(Console.ReadLine());
if (day <= 0 || day >= 8)// || or && для двойного условия
{
    Console.WriteLine("Please, try enter 0 < number <= 7 again");
    return;
}
else
{
    if(day >= 6)
    {
        Console.WriteLine("This is weekend, do something useful for yourself");
    }
    else
    {
        Console.WriteLine("Солнце еще высоко");
    }
}