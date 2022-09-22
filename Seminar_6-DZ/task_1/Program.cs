//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] EnterInt(){
    int array_length = 5;
    int[] user_array = new int[array_length];
    int user_input = 0;
    int counter = 0;

    do {
        Console.Write($"Введите число> ");
        user_input = Convert.ToInt32(Console.ReadLine());

        user_array[counter] = user_input;

        counter++;
    } while(counter != array_length);


    return user_array;
}


int CheckPositiveNumber(int[] array){
    int number_counter = 0;

    for (int i = 0; i < array.Length; i++){
        if (array[i] > 0){
            number_counter = number_counter + 1;
        }
    }

    return number_counter;
}

int[] user_array = EnterInt();
Console.WriteLine($"Положительных чисел введено: {CheckPositiveNumber(user_array)}");