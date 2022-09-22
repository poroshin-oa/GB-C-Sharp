// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Создание и заполнение массива
int[] CreateArray(int arr_size){
    int[] new_array = new int[arr_size];

    Random rnd = new Random();

    for (int i = 0; i < arr_size; i++){
        new_array[i] = rnd.Next(-10, 10);
    }

    return new_array;
}

// Метод для вывода массива
void PrintArray(int[] array){
    Console.WriteLine("\nСгенерированный массив:");

        for (int i = 0; i < array.Length; i++){
            Console.Write(Convert.ToString(array[i]) + "; ");
        }

    Console.Write("\n");
}

// Метод поиска чисел с нечетными индексами
int FindElemSum(int[] array){
    int event_counter = 0;
    Console.WriteLine("\nЧисла на нечетных индексах (в формате индекс -> число):");

    for (int i = 0; i <= array.Length; i++){
        if(i % 2 != 0){
            Console.WriteLine(Convert.ToString(i) + " -> " + Convert.ToString(array[i]));
            event_counter = event_counter + array[i];
        }
    }

    return event_counter;
}

int[] now_array = CreateArray(10);
PrintArray(now_array);
Console.WriteLine("\nСумма чисел с нечетным индексом: " + Convert.ToString(FindElemSum(now_array) + "\n"));


