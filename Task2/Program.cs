int [,] CreateArray(int strings, int columns)
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


void FindEl(int [,] array, int user_str, int user_col)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (user_str == i+1 && user_col == j+1)
            {
                Console.WriteLine(array[user_str, user_col]);
            }
            else if (user_str > array.GetLength(0) || user_col > array.GetLength(1))
            {
                Console.WriteLine("Такого элемента нет");   // не понимаю почему выводит несколько раз
                break;
            }    
        }
    }
}



Console.WriteLine("Введите кол-во строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] finalarray = CreateArray(str, col);
PrintArray(finalarray);

Console.WriteLine("Введите номер строки: ");
int user_string = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int user_column = Convert.ToInt32(Console.ReadLine());
FindEl(finalarray, user_string, user_column);