// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int EvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
    }
    return count;
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
// Задайте массив заполненный случайными положительными трёхзначными числами.
int[] way = CreateMassive(12, 100, 999);
// количество чётных чисел в массиве
int evenNum = EvenNumber(way);
// Вывод
Console.WriteLine($"[{(String.Join(" ", way))}] -> {evenNum}");