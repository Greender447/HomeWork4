// Задача 29: Напишите программу, которая задаёт массив из 8 элементов (от -10 до 10) и выводит их на экран.

// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]

// 6, 1, 3 -> [6, 1, 3]

Console.WriteLine("Ввtдите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
RandNumberArray(array);
PrintArray(array);
void RandNumberArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
         array[i] = new Random().Next(-9, 9);

    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}