Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[,] matrix = new int[m, n];

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

int MinSumInRow(int[,] arr) // медот поиска минимальной суммы элементо в строке
{
    int[] HelpArray = new int[arr.GetLength(0)]; // вспомогательный массив
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        int sum = 0;
        for (int columns = 0; columns < arr.GetLength(1); columns++)
        {
            sum = sum + arr[rows, columns];
        }
        HelpArray[rows] = sum;
    }
    int min = HelpArray.Min();
    int outRow = Array.IndexOf(HelpArray, min);
    return outRow;
}
Console.WriteLine("--------------------------------------------------");
PrintArray(FillArray(matrix));
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Наименьшая сумма элементов в строке: " + (MinSumInRow(matrix) + 1)); // Если считать строки с 1 если с 0 то вместо (MinSumInRow(matrix)+1) будет MinSumInRow(matrix) 
