int[,] FillArray(int[,] array) // метод заполнения массива по спирали
{
    int SizeX = array.GetUpperBound(0);
    int SizeY = array.GetUpperBound(1);
    int maxX = SizeX + 1;
    int maxY = SizeY;
    int dirX = 1;
    int dirY = 1;

    int x = -1;
    int y = 0;
    int val = 1;
    while ((maxX >= 0) && (maxY >= 0))
    {
        for (int xval = 1; xval <= maxX; xval++)
        {
            array[x + dirX * xval, y] = val;
            val++;
        }

        x = x + dirX * maxX;
        dirX = -dirX;
        maxX--;

        for (int yval = 1; yval <= maxY; yval++)
        {
            array[x, y + dirY * yval] = val;
            val++;
        }

        y = y + dirY * maxY;
        dirY = -dirY;
        maxY--;
    }

    return array;
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

int[,] CoilArray = new int[4, 4];
PrintArray(FillArray(CoilArray));