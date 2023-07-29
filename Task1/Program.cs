int [,] CreateArray2(int strings, int columns)
{
    int [,] array_two = new int [strings, columns];
    Random random = new Random();
    for (int i = 0; i < array_two.GetLength(0); i++)
    {
        for (int j = 0; j < array_two.GetLength(1); j++)
        {
            array_two[i, j] = random.Next(0, 100);
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    return array_two;
}

void PrintArray(int [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
        Console.Write(mass[i, j]);
        Console.Write(" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] finalarray = CreateArray2(str, col);
PrintArray(finalarray);
// Console.Write($"Итоговый массив: {PrintArray(finalarray)}");