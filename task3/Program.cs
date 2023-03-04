// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000000,1000001);
    }
}

void PrintArray(double[] array)
{
    Console.Write("The array is: ");
    int i = 0;
    while (i < array.Length)
    {
        Console.Write($"{array[i]}");
        i++;
        if (i < array.Length)
        {
            Console.Write($", ");
        }
        else
        {
            Console.Write($".");
        }
    }
}

    double MaxNum(double[] array)
    {
        double max = array[0];
        int i = 1;
        while (i < array.Length)
        {
            if (max > array[i])
            {
                max = max;
                i++;
            }
            else
            {
                max = array[i];
                i++;
            }
        }
        Console.WriteLine($"");
        Console.WriteLine($"The max number is {max}");
        return max;
    }

    double MinNum(double[] array)
    {
        double min = array[0];
        int i = 1;
        while (i < array.Length)
        {
            if (min < array[i])
            {
                min = min;
                i++;
            }
            else
            {
                min = array[i];
                i++;
            }
        }
        Console.WriteLine($"The min number is {min}");
        return min;
    }

    double Diff(double[] array)
    {
        double max = MaxNum(array);
        double min = MinNum(array);
        double difference = max - min;
        Console.WriteLine($"The difference is {difference}");
        return difference;
    }





    Console.WriteLine("Enter number of array elements");
    int n = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[n];

    FillArray(array);
    PrintArray(array);
    Diff(array);