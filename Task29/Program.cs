/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


Console.WriteLine("Введите массив: ");
int A = 8;
int[] array = new int[A];
for (int i = 0; i < A; i++)
{
    Console.Write($"Ввод {i} элемента: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вывод массива: [");
for (int j = 0; j < A - 1; j++)
{
    Console.Write($"{array[j]}" + ", ");
}
Console.WriteLine($"{array[A - 1]}" + "]");