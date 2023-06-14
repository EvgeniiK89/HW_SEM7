void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(0, 99));
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите размер строки массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбца массива: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, col];

FillArray(array);
PrintArray(array);

Console.WriteLine("Введите координату cтроки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату столбца: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > row && y > col)
    Console.WriteLine("Такого числа в массиве нет");
else
{
    object valueOfIndex = array.GetValue(x, y);
    Console.WriteLine($"Значение вводимого индекса координат: {valueOfIndex}");
}