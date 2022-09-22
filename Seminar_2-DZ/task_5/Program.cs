// Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет
// 15 -> нет
// 12 -> да

// Определение переменных
int user_integer;
int random_integer;
int result;
Random rnd = new Random();

// Ввод пользовательского числа
Console.WriteLine("Введите число: ");
user_integer = Convert.ToInt32(Console.ReadLine());

// Цикл
do {
    random_integer = rnd.Next(1, 99);
    result = random_integer % 2;
    Console.WriteLine(result);
}
while(random_integer != 10);
