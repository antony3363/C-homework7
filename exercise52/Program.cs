//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



double b;
double c = 0;
double d = 0;
double e = 0;
double f = 0;

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
            if (j == 0)
            {
                c+=b;
            }
            if (j == 1)
            {
                d+=b;
            }
            if (j == 2)
            {
                e+=b;
            }
            if (j == 3)
            {
                f+=b;
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
c/=3;
d/=3;
e/=3;
f/=3;
Console.WriteLine("Среднее арифметическое каждого столбца: " + c + "; " + d + "; " + e + "; " + f);








