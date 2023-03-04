// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }
}

void PrintArray(double[] arr)
{
    Console.Write("The array is: ");
    int i = 0;
    while (i < arr.Length)
    {
        Console.Write($"{arr[i]}");
        i++;
        if (i < arr.Length)
        {
            Console.Write($", ");
        }
        else
        {
            Console.Write($".");
        }
    }
}

void Sum(double [] arr)
{
    Console.WriteLine($"");
    Console.Write($"The sum is ");
    double sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    Console.Write($"{sum}.");
}





Console.WriteLine("Enter number of array elements");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];

FillArray(arr);
PrintArray(arr);
Sum(arr);