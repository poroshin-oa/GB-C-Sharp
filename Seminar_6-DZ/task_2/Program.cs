// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] InputValue(){
    int[] input_array = new int[4];

    Console.Write("Введите k1> ");
    input_array[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b1> ");
    input_array[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите k2> ");
    input_array[2] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b2> ");
    input_array[3] = Convert.ToInt32(Console.ReadLine());

    return input_array;
}

void PointCoord(int[] coord_array){
    // Вычисление координаты х методом системы уравнений (вычитаем из первого уравнения второе)
    // Умножение на -1 - перенос значения в другую часть уравнения
    double k_common = coord_array[0] - coord_array[2];
    double b_common = coord_array[1] - coord_array[3];
    double x = b_common * -1 / k_common;

    // Вычисление координаты y методом подстановки в первое уравнение
    double y = coord_array[0] * x + coord_array[1];

    Console.WriteLine($"b = {b_common} k = {k_common} x = {x}; y = {y}");
}

int[] user_array = InputValue();
PointCoord(user_array);

