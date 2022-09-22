﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Исходные данные
int input_int = 14212;
int[] numbers = new int[5];

// Цикл преобразования числа в массив
for(int i = 0; i < 5; i++){
    numbers[i] = input_int % 10;
    input_int = input_int / 10;
}

// Проверка, является ли число палиндромом
if (numbers[0] == numbers[4] && numbers[1] == numbers[3]){
    Console.WriteLine("Палиндром");
}
else{
    Console.WriteLine("Не палиндром");
}


