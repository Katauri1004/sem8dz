// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] NewRandArray(int rows, int columns)

{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 100);

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
int[,] array = NewRandArray(4, 4);
PrintArray(array);

void CalcSumRow(int[,] arr)
{
    int NumberRow = 0;
    int sum = 0;
    int MinSumInRow = 0;
    for (int c = 0; c < arr.GetLength(1); c++)
    {
        MinSumInRow = MinSumInRow + array[0, c];

    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            while (j < arr.GetLength(1))
            {
                sum = sum + arr[i, j];
                j++;
            }
            if (MinSumInRow > sum)
            {
                MinSumInRow = sum;
                NumberRow = i;

            }


        }

        sum = 0;

    }
    Console.WriteLine($"Строка с наименьшей суммой элементов = {MinSumInRow}, строка - {NumberRow+1}");

}

CalcSumRow(array);
