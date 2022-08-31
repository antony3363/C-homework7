//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет


Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
double b;
int c = 0;
int d = 0;

int t = 0;

int linesVol = 3;


int columnsVol = 4;

double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            b = Convert.ToDouble(new Random().Next(0, 10));
            array[i, j] = b;
            if (a == b)
            {
                c = i;
                d = j;
                t = 1;
            }
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
if (t == 1)
{
    Console.WriteLine(a + " -> " + c + " " + d);
}
else
{
    Console.WriteLine(a + " -> такого числа нет");
}
