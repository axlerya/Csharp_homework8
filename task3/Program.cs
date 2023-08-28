Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[,] matrixOne = new int[m, n]; // объявляем двумерных массивов
int[,] matrixTwo = new int[m, n];

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

int[,] MatrixMultiplication(int[,] arrOne, int[,] arrTwo)
{
    int[,] matrixOut = new int[m, n];
    for (int rows = 0; rows < arrOne.GetLength(0); rows++)
    {
        for (int columns = 0; columns < arrOne.GetLength(1); columns++)
        {
            matrixOut[rows, columns] = arrTwo[rows, columns] * arrOne[rows, columns];
        }
    }
    return matrixOut;
}
Console.WriteLine("--------------------------------------------------");
PrintArray(FillArray(matrixOne));
Console.WriteLine("--------------------------------------------------");
PrintArray(FillArray(matrixTwo));
Console.WriteLine("--------------------------------------------------");
PrintArray(MatrixMultiplication(matrixOne, matrixTwo));