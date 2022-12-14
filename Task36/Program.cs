// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int OddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = arr[i] + sum;
    }
    return sum;
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
// Задайте одномерный массив, заполненный случайными числами.
int[] way = CreateMassive(12, 0, 100);
// Найдите сумму элементов, стоящих на нечётных позициях.
int oddIndex = OddIndex(way);
// Вывод
Console.WriteLine($"[{(String.Join(" ", way))}] -> {oddIndex}");