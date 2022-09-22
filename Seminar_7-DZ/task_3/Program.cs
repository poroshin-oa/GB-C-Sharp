// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//
// Не получилось привести результат к типу double, поэтому написано под integer
// 
// Заполнение массива
int[,] FillArray(int[,] matrix){
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

// Вывод массива
void PrintArray(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

// Расчет среднего арифметического по столбцам
int[] CalcColumnMean(int[,] array){
    int string_count = array.GetLength(0);
    int column_count = array.GetLength(1);

    int[] column_mean = new int[column_count];

    for (int i = 0; i < column_count; i++){
        int column_sum = 0;
            for (int j = 0; j < string_count; j++){
                column_sum = column_sum + array[j, i];
                column_mean[i] = column_sum / string_count;
            }
    }
    return column_mean;
}

int[,] new_array = new int[3,4];
new_array = FillArray(new_array);
int[] result_mean = CalcColumnMean(new_array);

PrintArray(new_array);

Console.Write("Среднее арифметическое по столбцам: ");

foreach (int k in result_mean){
    Console.Write($"{k}; ");
}
Console.WriteLine();