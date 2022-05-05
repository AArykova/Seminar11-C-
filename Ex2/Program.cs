// Двумерный массив заполнен случайными натуральными числами от 1 до 10. 
//Найдите количество элементов, значение которых больше 5, и их сумму.

Console.WriteLine("Введите количество строк:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[lines, columns];

FillArray();
PrintArray();
SummaArray();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray()
{
    Console.WriteLine("Двумерный массив:");
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SummaArray()
{
    int summa = 0;
    int kol = 0;
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i, j] > 5)
            {
                summa += array[i, j];
                kol++;
            }
        }
    }
    Console.WriteLine("Сумма элементов больше 5 равна: " + summa);
    Console.WriteLine("Количество элементов больше 5 равно: " + kol);
}