// Двумерные массивы

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

int[,] table = new int[4,5];

PrintArray(FillArray(table));



