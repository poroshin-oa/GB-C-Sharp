// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//
// Вот здесь не уверен, требуется ли сборка финального числа в переменной? В условии ничего про это не сказано.
// Как конкатенацию без строк сделать, если требуется?
//
// Генерация случайного числа
Random rnd = new Random();
int input_integer = rnd.Next(100, 999);

// Получаем первую и третью цифру числа
int first_int = input_integer / 100;
int third_int = input_integer % 10;

// Вывод
Console.Write("Исходное число: ");
Console.WriteLine(input_integer);

Console.Write("Число с удаленной второй цифрой: ");
Console.Write(first_int);
Console.WriteLine(third_int);

