// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Max(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }
    return max;
}

int Min(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    return min;
}

int[] CreateMassive(int count, int begin, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end + 1);
    }
    return array;
}
// Задайте массив вещественных чисел.
int[] way = CreateMassive(10, 1, 100);
// Найдите разницу между максимальным и минимальным элементов массива.
int diff = Max(way) - Min(way);
// Вывод
Console.WriteLine($"[{(String.Join(" ", way))}] -> {diff}");