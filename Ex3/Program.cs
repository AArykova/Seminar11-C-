// Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет. 
//Постарайтесь воспользоваться только сложением или вычитанием.

Console.WriteLine("Введите год");
int year = Convert.ToInt32(Console.ReadLine());
/*
if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
{
    Console.WriteLine("Високосный год");
}
else Console.WriteLine("Не високосный год");
*/

Console.Write(LeapYear(year) ? "Високосный год" : "Не високосный год");
Console.WriteLine();

bool LeapYear(int years)
{
    return (((years % 4 == 0) && (years % 100 != 0)) || (years % 400 == 0));
}
