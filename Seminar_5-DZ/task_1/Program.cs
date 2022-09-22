// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Создание и заполнение массива
int[] CreateArray(int arr_size){
    int[] new_array = new int[arr_size];

    Random rnd = new Random();

    for (int i = 0; i < arr_size; i++){
        new_array[i] = rnd.Next(100, 999);
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

// Метод поиска количества четных чисел в массиве
int FindEventFromArray(int[] array){
    int event_counter = 0;

    for (int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0){
            event_counter = event_counter + 1;
        }
    }

    return event_counter;
}

int[] now_array = CreateArray(10);
PrintArray(now_array);
Console.WriteLine("\nКол-во четных чисел: " + Convert.ToString(FindEventFromArray(now_array) + "\n"));