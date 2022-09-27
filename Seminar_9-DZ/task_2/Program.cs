// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Ввод данных
int sum = 0;
int m = InputNumbers("Введите значение M: ");
int n = InputNumbers("Введите значение N: ");

// Обработка ввода
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

// Расчет суммы
int rekursion_int(int m, int n){
    if (m <= n){
        sum = sum + m;
        rekursion_int(m + 1, n);
    }

    return sum;
}

Console.WriteLine(rekursion_int(m, n));