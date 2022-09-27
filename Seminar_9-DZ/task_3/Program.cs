// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Ввод данных
int m = InputNumbers("Введите значение M: ");
int n = InputNumbers("Введите значение N: ");

// Обработка ввода
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

// Расчет функции Аккермана
int AkkermanFunc(int m, int n){
	if (m == 0){
		return n + 1;
	}
			
    if (m > 0 && n == 0){
		return AkkermanFunc(m - 1, 1);
	}
	
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
		
Console.WriteLine(AkkermanFunc(m, n));