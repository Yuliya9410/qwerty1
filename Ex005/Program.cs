
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] numbers = new int[10];

void CreateArray(int[] array, int min, int max)
{
    for (int i=0; i < array.Length; i++)
    {
    array[i] = new Random().Next(min, max);
    }
}

void ArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for(int i = 0; i < array.Length; i++)
    {
         if(array[i] % 2 ==1)
    {
        quantity++;
    }
    }
return quantity;
}

CreateArray(numbers,100,1000);
ArrayRandomNumbers(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Write($"Введите количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numberElements, int min, int max)
{
    int[] RandomNumbers = new int[numberElements];
    int sumElements = 0;
    Console.Write("Получившийся массив: ");

for(int i = 0; i < RandomNumbers.Length; i++)
{
    RandomNumbers[i] = new Random().Next(min,max);

   Console.Write(RandomNumbers[i] + " ");

   if(i % 2 != 1)
   {
    sumElements = sumElements + RandomNumbers[i];
   }
}
return sumElements;
}

int randomNumbers = RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");
*/
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for(int z = 0; z < numbers.Length; z++)
{
    if(numbers[z] > max)
    {
        max = numbers[z];
    }
    if(numbers[z] < min)
    {
        min = numbers[z];
    }

}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение  = {min}");
Console.WriteLine($"Разница между максимальным и минмальным значением = {max-min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
Console.Write("]");
Console.WriteLine();
}