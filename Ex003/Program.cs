
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void FiveDigitNumber(int number)
{
    int lastNum = number % 10;
    int firstNum = number / 10000;
    if (firstNum == lastNum)
    {
    lastNum = (number % 100) / 10;
    firstNum = (number / 1000) % 10;
    if ( firstNum == lastNum) 
    Console.Write ($"{number} -> Да");
    }
    else 
    Console.Write ($"{number} ->  Нет");
    
}
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
FiveDigitNumber(number);
*/
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    
    return Math.Sqrt (Math.Pow(x2 -x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow( z2 - z1, 2));

}
Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double xz = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input x2: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double yz = Convert.ToDouble(Console.ReadLine());
double coordinate = FindDistance (xa, xb, xz, ya, yb, yz);
Console.WriteLine($"Distance is {coordinate}");
*/

// Задача 23. Напишите программу, которая на вход принимает число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write ("Введите число N: ");
int number = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Таблица кубов чисел от 1 до {number}");
Console.WriteLine();

Console.WriteLine("Число\t куб числа");

for (int i = 1; i <= number; i++ )
{
    Console.WriteLine("{0}\t{1}", i,  Math.Pow(i, 3));
}