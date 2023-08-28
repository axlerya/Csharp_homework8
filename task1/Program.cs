Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[,] matrixBeforeSort = new int[m, n]; // объявляем два двухмерных массива до сортироки и полсе
int[,] matrixAfterSort = new int[m, n];
int[] sort = new int[n]; // одномерный массив для сортировки 

int[,] FillArray(int[,] arr) // метод заполнения массива случайными числами 
{
    for (int rows = 0; rows < arr.GetLength(0); rows++) 
    {
        for (int columns = 0; columns < arr.GetLength(1); columns++)
        {
            arr[rows, columns] = rand.Next(0, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr) // метод вывода массива в консоль 
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < arr.GetLength(1); columns++)
        {
            Console.Write(arr[rows, columns] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] arr)// метод сортировки массива по убыванию
{
    for (int rows = 0; rows < matrixBeforeSort.GetLength(0); rows++)
    {
        for (int columns1 = 0; columns1 < matrixBeforeSort.GetLength(1); columns1++)
            sort[columns1] = arr[rows, columns1];
        Array.Sort(sort);
        Array.Reverse(sort);
        for (int columns2 = 0; columns2 < matrixBeforeSort.GetLength(1); columns2++)
        {
            arr[rows, columns2] = sort[columns2];
        }
    }
    return arr;
}

Console.WriteLine("--------------------------------------------------"); // костыль чтобы лучше видеть в консоли
Console.WriteLine("До сортировки");
PrintArray(FillArray(matrixBeforeSort));
matrixAfterSort = matrixBeforeSort;
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("После сортировки");
PrintArray(SortArray(matrixAfterSort));