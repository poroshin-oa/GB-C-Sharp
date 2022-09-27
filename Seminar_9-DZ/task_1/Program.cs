// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Ввод данных
int n = InputNumbers("Введите значение N: ");

// Обработка ввода
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

// Вывод чисел
void rekursion_int(int input_int){
    if (input_int > 0){
        Console.WriteLine(input_int);
        rekursion_int(input_int - 1);
    }
}

rekursion_int(n);