// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

// Расчет сумм строк
int[] RowsSum(int[,] array){
    int[] result_array = new int[array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++){
        int row_sum = 0;

        for (int j = 0; j < array.GetLength(1); j++){
                row_sum = row_sum + array[i,j];
            }
        result_array[i] = row_sum;
    }

    return result_array;
}

// Поиск наименьшей строки
int FindMin(int[] array){

    int min_elem = array[0];
    int min_index = 0;

    for (int i = 0; i < array.Length; i++){
        if (array[i] < min_elem){
            min_elem = array[i];
            min_index = i;
        }
    }
    return min_index;
}

int[,] table = new int[4,5];

Console.WriteLine("Исходный массив:");
PrintArray(FillArray(table));

int[] sums = RowsSum(table);
Console.WriteLine("\nМассив сумм строк:");
foreach (int k in sums){
    Console.WriteLine(k);
}

int result_index = FindMin(sums);
Console.WriteLine("\nСтрока с минимальной суммой элементов:");
Console.WriteLine($"Индекс строки: {result_index}; Значение суммы: {sums[result_index]}");


