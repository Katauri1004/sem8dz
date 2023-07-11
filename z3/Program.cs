//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] NewRandArray(int rows, int columns)

{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 9);

        }

    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"[{arr[i, j]}]  ");
        }
        Console.WriteLine("");
    }
}
// r c
int[,] array = NewRandArray(3, 3);
Console.WriteLine("Первая матрица :");
Console.WriteLine("");
PrintArray(array);
Console.WriteLine("");

int[,] array2 = NewRandArray(3, 3);
Console.WriteLine("Вторая матрица :");
Console.WriteLine("");
PrintArray(array2);

int[,] array3 = new int[3, 3];
int sum = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array3[i,j]=0;
        for(int c = 0;c<array.GetLength(1);c++)
        {
            array3[i,j] = array3[i,j] + array[i,c] * array2[c,j];
        }
    
    }

}
Console.WriteLine("");
Console.WriteLine("Перемноженная матрица :");
Console.WriteLine("");
PrintArray(array3);

