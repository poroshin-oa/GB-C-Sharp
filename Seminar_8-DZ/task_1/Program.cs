// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Вывод массива
void PrintArray(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

// Заполнение массива
int[,] FillArray(int[,] matrix){
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = rnd.Next(1, 100);
        }
    }

    return matrix;
}

// Построчная сортировка
int[,] SortLine(int[,] input_array){
    for (int i = 0; i < input_array.GetLength(0); i++){
        for (int j = 0; j < input_array.GetLength(1); j++){
            for (int k = 0; k < input_array.GetLength(1) - 1; k++){
                if (input_array[i, k] < input_array[i, k + 1]){
                    int temp = input_array[i, k + 1];
                    input_array[i, k + 1] = input_array[i, k];
                    input_array[i, k] = temp;
                }
            }
        }
    }

    return input_array;
}

int[,] table = new int[4,5];
Console.WriteLine("Исходный массив");
PrintArray(FillArray(table));

Console.WriteLine("\nОтсортированный массив");
PrintArray(SortLine(table));
