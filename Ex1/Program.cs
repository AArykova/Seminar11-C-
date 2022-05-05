// На вход подаются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].

Console.WriteLine("Введите число n ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m ");
int numberM = Convert.ToInt32(Console.ReadLine());
int kol = 10;
int[] array = new int[kol];
Random rnd = new Random();

if (numberN >= numberM)
{
    Console.WriteLine("Ведите корректные числа (n < m)");
}
else
{
    FillArray(numberN, numberM);
    PrintArray();
}

void FillArray(int n, int m)
{
    for (int i = 0; i < kol; i++)
    {
        array[i] = rnd.Next(n, m);
    }
}
void PrintArray()
{
    for (int i = 0; i < kol; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}