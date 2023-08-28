int[,,] RandomArray(int[,,] arr)
{
    int count = 1;
    for (int rows1 = 0; rows1 < arr.GetLength(0); rows1++)
    {
        for (int columns1 = 0; columns1 < arr.GetLength(1); columns1++)
        {
            for (int field1 = 0; field1 < arr.GetLength(2); field1++)
            {
                arr[rows1, columns1, field1] = 10 * count;
                count++;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int rows2 = 0; rows2 < arr.GetLength(0); rows2++)
    {
        for (int columns2 = 0; columns2 < arr.GetLength(1); columns2++)
        {
            Console.WriteLine();
            for (int field2 = 0; field2 < arr.GetLength(2); field2++)
            {
                Console.Write($"{arr[rows2, columns2, field2]}({rows2},{columns2},{field2}) ");
            }
        }
    }
}

int[,,] myArray = new int[2, 2, 2];
PrintArray(RandomArray(myArray));