// Отсортировать по убыванию элементы каждой строки двумерного массива


void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("__________");
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = new Random().Next(-99,100);
        }
    }
}

void Sorting(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            int minIndex = j;
            for (int k = j+1; k < collection.GetLength(1); k++)
            {
                if (collection[i,k] < collection[i,minIndex]) minIndex = k;
            }
            int mem = collection[i,j];
            collection[i,j] = collection[i,minIndex];
            collection[i,minIndex] = mem;
        }
    }
}

int[,] array = new int[3,4];

FillArray(array);
PrintArray(array);
Sorting(array);
PrintArray(array);