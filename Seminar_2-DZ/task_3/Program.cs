﻿// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
//
// Неясно по условию, ограничено число разрядов, или нет.
// Сделано для числа с максимум тремя разрядами.
// Расчет кол-ва разрядов сделан через цикл, так что теоретически можно переделать для числа с любым кол-м разрядов.
//
//
// Входное число
int input_integer = 439;
int check_digit = input_integer;

// Подсчет количества разрядов в числе
int digit_result = 0;
while(check_digit > 0)
    {
        check_digit = check_digit / 10;
        digit_result++;
    }


// Если кол-во разрядов меньше 3, выводим сообщение
// Если больше или равно 3, выводим третью цифру
if (digit_result < 3){
    Console.WriteLine("Третья цифра отсутствует");
}
else{
    Console.WriteLine(input_integer % 10);
}





