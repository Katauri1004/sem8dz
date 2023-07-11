/* Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] NewRandArray(int rows, int columns)

{
    int [,] array = new int [rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows;i++)
    {
        for (int j = 0; j < columns;j++)   
        {
            array[i,j] = random.Next(1,100);
            
        }
    
    }
    return array;
}

void PrintArray(int [,] arr)
{
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write($"[{arr[i,j]}]  ");
        }
        Console.WriteLine("");
    }
}
                          // r c
int [,] array = NewRandArray(4,4);
Console.WriteLine("Исходный массив:");
PrintArray(array);

for(int i = 0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {   
           
           for (int c=0; c<array.GetLength(1)-1; c++)
           {

           
           
            if(array[i,c]<array[i,c+1])
            {
              int temp = array[i,c+1];
              array[i,c+1]=array[i,c];
              array[i,c] = temp;

    
            }
           
           }
    }
    }
Console.WriteLine("");
Console.WriteLine("Отсортированный массив:");
PrintArray(array);
