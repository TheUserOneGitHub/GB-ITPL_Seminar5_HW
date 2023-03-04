// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    Console.Write("Array: ");
    while (position < count)
    {
        Console.Write($"{array[position]}");
        position++;
        if (position < count)
        {
            Console.Write($", ");
        }
        else
        {
            Console.Write($"");
        }
    }
}

void Method(int[] array)
{
    int length = array.Length;
    int i = 0;
    int even = 0;
    while (i < array.Length)
    {
        if (array[i] % 2 == 0)
        {
            even = even + 1;
            i++;
        }
        else
        {
            i++;
        }
    }
    Console.WriteLine($"");
    Console.WriteLine($"Total of even numbers is {even}");
}





Console.WriteLine("Enter the number of array elements");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
FillArray(array);
PrintArray(array);
Method(array);