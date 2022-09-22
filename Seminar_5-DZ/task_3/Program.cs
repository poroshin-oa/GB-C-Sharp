// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Создание и заполнение массива
double[] CreateArray(int arr_size){
    double[] new_array = new double[arr_size];

    Random rnd = new Random();

    for (int i = 0; i < arr_size; i++){
        new_array[i] = Math.Round(rnd.NextDouble() * 10, 2);
    }

    return new_array;
}

// Метод для вывода массива
void PrintArray(double[] array){
        for (int i = 0; i < array.Length; i++){
            Console.Write(Convert.ToString(array[i]) + "; ");
        }

    Console.Write("\n");
}

// Метод сортировки массива
double[] SortArray(double[] array){
    for (int i = 0; i < array.Length; i++){
        for (int j = 0; j <array.Length - 1; j++){
            if (array[j] > array[j+1]){
                double temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }

    return array;
}

// Расчет разности
double CalcDifference(double[] array){
    double[] sort_array = SortArray(array);
    double diff = Math.Round(sort_array[sort_array.Length - 1] - sort_array[0], 2);
    
    return diff;
}

Console.WriteLine("\nСгенерированный массив:");
double[] now_array = CreateArray(10);
PrintArray(now_array);

Console.WriteLine("\nОтсортированный массив:");
double[] sorted_array = SortArray(now_array);
PrintArray(sorted_array);

Console.WriteLine("\nРазность между максимальным и минимальным элементами массива:");
Console.WriteLine(CalcDifference(now_array));
Console.WriteLine("\n");