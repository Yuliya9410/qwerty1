// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
{
    result = result * numberA;
}

return result;

}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("A в степени B равно: " + exponentiation);
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumber (int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }

return result;
}

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumNumber= SumNumber(numberN);
Console.WriteLine("Сумма всех цифр в числе равна: " + sumNumber);
*/
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = AskNumbers();
Console.WriteLine ($"{String.Join(", ", array)} > [{String.Join(" , " , array)}]");

int [] AskNumbers ()
{
    int [] array = new int [8];
    for ( int i = 0; i < array.Length; i++)
    {
        array[i] = AskNumber (i + 1);
    }

return array;

}

int AskNumber (int i)
{
    Console.Write($"Введите число {i}: ");
    return int.Parse (Console.ReadLine());
}