// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Определение размера
int m = 4;
int n = 6;

// Определение границ рандома для double
double max = 10;
double min = -10;

// Заполнение массива
double[,] FillArray(double[,] matrix){
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
        }
    }

    return matrix;
}

// Вывод массива
void PrintArray(double[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

double[,] table = new double[m,n];

PrintArray(FillArray(table));