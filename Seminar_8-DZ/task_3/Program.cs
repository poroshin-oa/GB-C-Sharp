// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Ввод размерностей матриц
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");

// Создание и заполнение матриц
int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[n, p];
int[,] resultMatrix = new int[m, p];

FillArray(firstMatrix);
FillArray(secondMatrix);

// Обработка ввода
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
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

// Перемножение матриц
int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix){
    for (int i = 0; i < resultMatrix.GetLength(0); i++){
        for (int j = 0; j < resultMatrix.GetLength(1); j++){

        int sum = 0;

            for (int k = 0; k < firstMartrix.GetLength(1); k++){
                sum = sum + firstMartrix[i,k] * secondMartrix[k,j];
            }
        
        resultMatrix[i,j] = sum;
        
        }
    }

    return resultMatrix;
}

Console.WriteLine("\nПервая матрица:");
PrintArray(firstMatrix);

Console.WriteLine("\nВторая матрица:");
PrintArray(secondMatrix);

Console.WriteLine("\nРезультат перемножения:");
PrintArray(MultiplyMatrix(firstMatrix, secondMatrix));