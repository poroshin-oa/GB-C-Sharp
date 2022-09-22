// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

// Входные данные
int position1 = 0;
int position2 = 50;

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

// Вывод массива
void PrintArray(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

// Поиск элемента по индексу
int FindElem(int index1, int index2, int[,] array){
    try{
        return array[index1, index2];
    }
    catch{
        return 0;
    }
}

int[,] table = new int[4,5];
PrintArray(FillArray(table));
int result = FindElem(position1, position2, table);
string out_result = "";

if(result == 0){
    out_result = "Элемента нет";
 }
 else{
    out_result = Convert.ToString(result);
 }

Console.WriteLine($"\n{out_result}");